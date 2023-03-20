import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, combineLatest, map, switchMap } from 'rxjs';
import { BooksService } from 'src/app/books/services/books.service';
import { Book } from 'src/app/model/Book';
import { CartedItem } from 'src/app/model/customer-cart/CartedItem';
import { SelectedItem } from 'src/app/model/customer-cart/SelectedItem';

@Injectable({
  providedIn: 'root'
})
export class CartService {
  private selectedCartItems: SelectedItem[] = [];
  selectedCartItems$ = new BehaviorSubject<SelectedItem[]>([]);
  selectedProducts$ = this.getChosenProducts();

  constructor(private productService: BooksService) {}

  getCartItems = () => this.selectedCartItems$;

  getChosenProducts(): Observable<Book[]> {
    return this.productService
      .getAllBooks()
      .pipe(
        switchMap((products) =>
          this.selectedCartItems$.pipe(
            map((selectedItems) =>
              products.filter((p) =>
                selectedItems.some((selected) => selected.id === p.id)
              )
            )
          )
        )
      );
  }

  getChosenCartItemsById(id: number): Observable<Book | undefined> {
    return this.selectedCartItems$.pipe(
      map((products) => products.find((product) => product.id === id))
    );
  }

  getChosenCartItems(): Observable<CartedItem[]> {
    return combineLatest([
      this.selectedProducts$,
      this.selectedCartItems$,
    ]).pipe(
      map(([products, cartItems]) => {
        const chosenCartItems: CartedItem[] = products.map((product) => {
          const cartItem = cartItems.find((item) => item.id === product.id);
          const quantity = cartItem ? cartItem.quantity : 1;

          return {
            id: product.id,
            quantity,
            name: product.title,
            imageSrc: product.image,
            price: product.price,
          };
        });
        return chosenCartItems;
      })
    );
  }

  addToCart(product: Book, quantity: number = 1) {
    if (!product) return;

    const productWithQuantity: Book = {
      ...product,
      quantity,
    };

    const productIdx = this.selectedCartItems.findIndex(
      (p: SelectedItem) => p.id === productWithQuantity.id
    );

    if (productIdx !== -1) {
      // update item quantity in cart
      this.selectedCartItems[productIdx].quantity = quantity;
    } else {
      // add new item to card if not added before
      this.selectedCartItems.push({
        ...product,
        id: productWithQuantity.id,
        quantity: productWithQuantity.quantity,
      });
    }

    this.selectedCartItems$.next(this.selectedCartItems);
  }

  public removeItemFromCart(itemId: number): void {
    const index = this.selectedCartItems.findIndex(
      (item) => item.id === itemId
    );
    if (index !== -1) {
      this.selectedCartItems.splice(index, 1);
      this.selectedCartItems$.next(this.selectedCartItems);
    }
  }

  public clearCart = () => this.selectedCartItems$.next([]);
}

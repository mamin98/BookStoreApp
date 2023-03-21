import { Injectable } from '@angular/core';
import {
  BehaviorSubject,
  Observable,
  combineLatest,
  map,
  switchMap,
} from 'rxjs';
import { BooksService } from 'src/app/books/services/books.service';
import { CartAction } from 'src/app/enums/card-action';
import { LocalStorageService } from 'src/app/local-storage.service';
import { Book } from 'src/app/model/Book';
import { CartedItem } from 'src/app/model/customer-cart/CartedItem';
import { SelectedItem } from 'src/app/model/customer-cart/SelectedItem';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  private selectedCartItems: SelectedItem[] = [];
  selectedCartItems$ = new BehaviorSubject<SelectedItem[]>([]);
  selectedProducts$ = this.getChosenProducts();

  // unique key for local storage
  private readonly cartItemsKey = 'cart-items';
  private readonly selectedItemsCountKey = 'selected-items-count';

  // selected items by user subject meant for syncing cart header (cart count)
  private selectedItemsCount = new BehaviorSubject<number>(0);
  allSelectedQuantity: number = 0;
  selectedItemsCount$ = this.selectedItemsCount.asObservable();

  constructor(
    private productService: BooksService,
    private localStore: LocalStorageService
  ) {
    // local storage Init
    const localItemsData = this.localStore.getData(this.cartItemsKey);

    if (localItemsData) {
      const selectedCartItems = JSON.parse(localItemsData) as SelectedItem[];
      this.selectedCartItems = selectedCartItems;
      this.selectedCartItems$.next(selectedCartItems);
    }
    // quantity - local storage setup
    const selectedItemsCount = Number(
      localStorage.getItem(this.selectedItemsCountKey)
    );
    if (selectedItemsCount) {
      this.selectedItemsCount.next(selectedItemsCount);
      this.allSelectedQuantity = selectedItemsCount;
    }
    this.selectedItemsCount.subscribe((count: number) => {
      localStore.saveData(this.selectedItemsCountKey, count.toString());
      this.allSelectedQuantity = count;
    });
  }

  updateQuantityCount(cardAction: CartAction) {
    cardAction === CartAction.Increment
      ? (this.allSelectedQuantity += 1)
      : (this.allSelectedQuantity -= 1);

    this.selectedItemsCount.next(this.allSelectedQuantity);
  }

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
    // subscribe to changes of user selected products & update local storage
    this.selectedCartItems$.subscribe((items) => {
      localStorage.setItem(this.cartItemsKey, JSON.stringify(items));
    });
    this.selectedCartItems$.next(this.selectedCartItems);
  }

  public removeItemFromCart(itemId: number): void {
    const index = this.selectedCartItems.findIndex(
      (item) => item.id === itemId
    );
    if (index !== -1) {
      this.selectedCartItems.splice(index, 1);
      this.selectedCartItems$.next(this.selectedCartItems);
      // subscribe to changes of user selected products & update local storage
      this.selectedCartItems$.subscribe((items) => {
        localStorage.setItem(this.cartItemsKey, JSON.stringify(items));
      });
    }
  }

  public clearCart = () => {
    this.selectedCartItems$.next([]);
    this.localStore.clearData();
  };
}

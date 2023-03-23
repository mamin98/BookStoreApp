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
  selectedItemsCount$ = this.selectedItemsCount.asObservable();

  // local reference for totaling selected cart quantity of carts quantities
  // used instead of selected count observable for needed initial value
  allSelectedQuantity: number = 0;

  constructor(
    private productService: BooksService,
    private localStore: LocalStorageService
  ) {
    // local storage Init
    const localItemsData = this.localStore.getData(this.cartItemsKey);

    if (localItemsData) {
      // allSelectedQuantity
      const selectedStorageCartItems = JSON.parse(
        localItemsData
      ) as SelectedItem[];
      this.selectedCartItems = selectedStorageCartItems;
      this.selectedCartItems$.next(selectedStorageCartItems);
      this.allSelectedQuantity = selectedStorageCartItems.reduce(
        (acc, curr) => acc + curr.quantity,
        0
      );
      localStore.saveData(
        this.selectedItemsCountKey,
        this.allSelectedQuantity.toString()
      );
    }

    // quantity - local storage sync
    const selectedItemsCount = Number(
      localStorage.getItem(this.selectedItemsCountKey)
    );
    if (selectedItemsCount) {
      this.selectedItemsCount.next(selectedItemsCount);
      this.allSelectedQuantity = selectedItemsCount;
    }
  }

  updateQuantityCount(cartAction: CartAction) {
    if (cartAction === CartAction.Increment) this.allSelectedQuantity += 1;

    if (cartAction === CartAction.Decrement)
      this.allSelectedQuantity >= 1 ? (this.allSelectedQuantity -= 1) : null;

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

      // subscribe to changes of user selected products & update local storage
      this.selectedCartItems$.next(this.selectedCartItems);
      this.selectedCartItems$.subscribe((items) => {
        // sync carted items with local storage
        localStorage.setItem(this.cartItemsKey, JSON.stringify(items));

        this.allSelectedQuantity = this.selectedCartItems.reduce(
          (acc, curr) => acc + curr.quantity,
          0
        );
        this.selectedItemsCount.next(this.allSelectedQuantity);

        // sync quantity with local storage
        this.localStore.saveData(
          this.selectedItemsCountKey,
          this.allSelectedQuantity.toString()
        );
      });
    }
  }

  public clearCart = () => {
    this.selectedCartItems$.next([]);
    this.localStore.deleteData(this.cartItemsKey);
    this.localStore.deleteData(this.selectedItemsCountKey);
    this.selectedItemsCount.next(0);
  };
}

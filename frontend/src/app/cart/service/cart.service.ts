import { Injectable } from '@angular/core';
import {
  BehaviorSubject,
  Observable,
  map,
  of,
  switchMap,
  take,
  tap,
} from 'rxjs';
import { CartAction } from 'src/app/constants/cart-action';
import { LocalStorageService } from 'src/app/local-storage.service';
import { Book } from 'src/app/model/Book';
import { CartedProductItem } from 'src/app/model/customer-cart/CartedProductItem';
import { SelectedItem } from 'src/app/model/customer-cart/SelectedItem';

@Injectable({
  providedIn: 'root',
})
export class CartService {
  selectedCartItems$ = new BehaviorSubject<CartedProductItem[]>([]);

  // unique key for local storage
  private readonly cartItemsKey = 'cart-items';
  private readonly selectedItemsCountKey = 'selected-items-count';

  // selected items by user subject meant for syncing cart header (cart count)
  selectedItemsCount$ = new BehaviorSubject<number>(0);

  getSelectedItemsCount$ = this.selectedCartItems$.pipe(
    map((items) => items.reduce((acc, item) => acc + item.quantity, 0))
  );

  constructor(private localStore: LocalStorageService) {
    // local storage Init
    const localItemsData = this.localStore.getData(this.cartItemsKey);

    if (localItemsData) {
      // get selected items from local storage if any

      const selectedCartItemsStorage: CartedProductItem[] = JSON.parse(
        localItemsData
      ).filter((selectedBook: Book) => selectedBook.quantity !== 0);

      this.selectedCartItems$.next(selectedCartItemsStorage);
    }
  }

  addToCart(product: CartedProductItem, cartAction: CartAction) {
    if (!product) return;

    this.selectedCartItems$.pipe(take(1)).subscribe((selectedItems) => {
      const selectedProduct = selectedItems.find(
        (p: SelectedItem) => p.id === product.id
      );

      // for the already selected item, update quanity according to cart action
      if (selectedProduct) {
        this.updateTotalQuantityCount(cartAction, selectedProduct.id);
        return;
      }
      // Add new item to card if not added before
      this.selectedCartItems$.pipe(take(1)).subscribe((selectedCartItems) => {
        const updatedCartItems = [
          ...selectedCartItems,
          {
            ...product,
            quantity: 1, // user selected quantity rather than product in-stock quantity
          },
        ];
        this.selectedCartItems$.next(updatedCartItems);
      });

      // for the first selected item, intialize quanity to 1
      this.selectedItemsCount$
        .pipe(
          take(1),
          map(() => 1)
        )
        .subscribe((updatedCount) => {
          this.selectedItemsCount$.next(updatedCount);
        });
    });

    // subscribe to changes of user selected products & update local storage
    this.selectedCartItems$.subscribe((items) => {
      localStorage.setItem(this.cartItemsKey, JSON.stringify(items));
    });
  }

  private updateTotalQuantityCount(cartAction: CartAction, productId: number) {
    if (!cartAction) console.error('missing Cart Action');

    if (cartAction === CartAction.Increment) {
      this.handleCartIncrement(productId);
    }

    if (cartAction === CartAction.Decrement) {
      this.handleCartDecrement(productId);
    }
  }

  private handleCartIncrement(productId: number) {
    this.selectedCartItems$
      .pipe(
        take(1),
        map((items) => {
          const selectedItem = items.find((item) => item.id === productId);
          if (selectedItem) {
            selectedItem.quantity += 1;
          }
          return items;
        }),
        tap((items) => {
          this.selectedCartItems$.next([...items]);
        })
      )
      .subscribe((selected) => this.selectedCartItems$.next(selected));
  }
  private handleCartDecrement(productId: number) {
    this.selectedCartItems$
      .pipe(
        take(1),
        map((items) => {
          const selectedItem = items.find((item) => item.id === productId);
          if (selectedItem && selectedItem.quantity > 1) {
            selectedItem.quantity -= 1;
          }
          return items;
        }),
        tap((items) => {
          this.selectedCartItems$.next([...items]);
        })
      )
      .subscribe((selected) => this.selectedCartItems$.next(selected));
  }

  getChosenCartItemsById(id: any): Observable<CartedProductItem | undefined> {
    return this.selectedCartItems$.pipe(
      map((products) => products.find((product) => product.id === id)),
      switchMap((product) => {
        if (product) {
          return of(product);
        } else {
          return of(undefined);
        }
      })
    );
  }

  removeItemFromCart(itemId: number): void {
    const updatedCartItems = this.selectedCartItems$.value.filter(
      (item) => item.id !== itemId
    );
    this.updateTotalQuantityCount(CartAction.Increment, itemId);
    this.selectedCartItems$.next(updatedCartItems);

    // subscribe to changes of user selected products & update local storage
    this.selectedCartItems$.subscribe((items) => {
      // sync carted items with local storage
      localStorage.setItem(this.cartItemsKey, JSON.stringify(items));
    });
  }

  clearCart = () => {
    // global count reset
    this.selectedItemsCount$.next(0);

    // chosen cart items reset
    this.selectedCartItems$.next([]);

    // clear local storage
    this.localStore.deleteData(this.cartItemsKey);
    this.localStore.deleteData(this.selectedItemsCountKey);
  };
}

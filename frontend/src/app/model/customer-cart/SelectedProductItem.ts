import { Book } from '../Book';

export interface SelectedProductItem extends Book {
  selectedQuantity: number;
}

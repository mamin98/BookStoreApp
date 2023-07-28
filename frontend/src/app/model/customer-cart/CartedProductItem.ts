import { Book } from '../Book';
import { SelectedItem } from './SelectedItem';

export interface CartedProductItem
  extends SelectedItem,
    Pick<Book, 'id' | 'title' | 'image' | 'price'> {}

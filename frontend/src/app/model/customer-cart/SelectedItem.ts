import { Book } from '../Book';

export interface SelectedItem extends Book {
  id: number;
  quantity: number;
}

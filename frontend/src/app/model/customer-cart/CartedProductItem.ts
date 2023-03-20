import { Book } from '../Book';
import { CartedItem } from './CartedItem';

export interface CartedProductItem extends CartedItem, Book {}

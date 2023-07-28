import { Review } from './Review';

export interface Book {
  id: number;
  title: string;
  image: string;
  price: number;
  quantity: number;
  authorName: string;
  publisherName: string;
  category?: string;
  ratings: number;
  reviews: Review[];
}

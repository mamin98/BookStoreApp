export interface CartPayload {
  customerId: number;
  cartItems: {
    id: number;
    quantity: number;
  }[];
}

export interface CartPayload {
  customerId: number;
  cartItems: Record<number, { quantity: number }>;
}

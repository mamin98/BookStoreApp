export type CartPayload = {
  customerId: number;
  cartItems: Record<number, { quantity: number }>;
};

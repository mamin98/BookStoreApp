export const CartAction = {
  Increment: 'Increment',
  Decrement: 'Decrement',
} as const;

type ObjectValues<T> = T[keyof T];

export type CartAction = ObjectValues<typeof CartAction>;

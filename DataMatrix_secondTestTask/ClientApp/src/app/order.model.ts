export interface Order {
  id: number;
  name: string;
  count: number;
  price: number;
  isDelivery: boolean;
  address?: string;
}

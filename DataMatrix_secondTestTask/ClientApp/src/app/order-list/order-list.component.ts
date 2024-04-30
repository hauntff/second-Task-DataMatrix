import { Component, OnInit } from '@angular/core';
import { OrderService } from '../order.service';
import { Order } from '../order.model';

@Component({
  selector: 'app-order-list',
  templateUrl: './order-list.component.html',
})
export class OrderListComponent implements OnInit {
  orders: Order[] = [];

  constructor(private orderService: OrderService) { }

  ngOnInit(): void {
    this.loadOrders();
  }

  loadOrders(): void {
    this.orderService.getPaged(1, 10) // Example: page 1, page size 10
      .subscribe(orders => {
        this.orders = orders;
      });
  }

  deleteOrder(id: number): void {
    this.orderService.deleteOrder(id)
      .subscribe(() => {
        window.location.reload() //// Refresh orders after deletion
      });
  }
}

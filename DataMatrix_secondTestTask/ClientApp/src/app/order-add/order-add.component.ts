import { Component } from '@angular/core';
import { OrderService } from '../order.service';
import { Router } from '@angular/router';
import { Order } from '../order.model';

@Component({
  selector: 'app-order-add',
  templateUrl: './order-add.component.html',
})
export class OrderAddComponent {
  order: Order = {
    id: 0,
    name: '',
    count: 0,
    price: 0,
    isDelivery: false,
    address: ''
  };

  constructor(private orderService: OrderService, private router: Router) { }

  addOrder(): void {
    this.orderService.addOrder(this.order)
      .subscribe(() => {
        this.router.navigate(['/orders']); // Navigate back to orders page after successful addition
      });
  }
}

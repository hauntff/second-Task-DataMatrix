import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Order } from './order.model';

@Injectable({
  providedIn: 'root'
})
export class OrderService {
  private baseUrl = 'https://localhost:7087/Order';

  constructor(private http: HttpClient) { }

  getPaged(page: number, pageSize: number): Observable<Order[]> {
    return this.http.get<Order[]>(`${this.baseUrl}/paged?page=${page}&pageSize=${pageSize}`);
  }

  addOrder(order: Order): Observable<any> {
    return this.http.post(`${this.baseUrl}/add`, order);
  }

  deleteOrder(id: number): Observable<any> {
    return this.http.delete(`${this.baseUrl}/delete?id=${id}`);
  }
}

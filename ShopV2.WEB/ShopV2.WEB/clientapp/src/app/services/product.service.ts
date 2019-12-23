import { Product } from 'src/app/Product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private url = "https://localhost:44371/api/products";
constructor(private http : HttpClient) { }
getProducts(){
  return this.http.get<Product[]>(this.url);
}
}

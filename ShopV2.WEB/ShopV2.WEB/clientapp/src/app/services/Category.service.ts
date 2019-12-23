import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Category } from "../Category";

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  private url = "https://localhost:44371/api/categories";
constructor(private http:HttpClient) { }
getCategories(){
  return this.http.get<Category[]>(this.url);
}
}

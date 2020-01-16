import { Product } from 'src/app/Product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { parseSelectorToR3Selector } from '@angular/compiler/src/core';
@Injectable({
  providedIn: 'root'
})
export class ProductService {
  private url = "https://localhost:44371/api/products";
constructor(private http : HttpClient) { }
getProducts(filter){
  this.toQueryString(filter);
  var s = this.http.get(this.url+'?'+this.toQueryString(filter));
  
  return s;
}

toQueryString(obj){
  var parts = [];
for(var property in obj){
  var value = obj[property];
  if(value!=null && value != undefined &&  value !=''){
      parts.push(encodeURIComponent(property)+'='+encodeURIComponent(value))
  }}
  return parts.join('&');
}
create(product){
  return this.http.post(this.url, product);
}
getProduct(id){
  return this.http.get(this.url+"/"+id);
}

update(product){
  return this.http.put(this.url+"/"+product.id, product)
}

delete(id){
  return this.http.delete(this.url+"/"+id);
}
}

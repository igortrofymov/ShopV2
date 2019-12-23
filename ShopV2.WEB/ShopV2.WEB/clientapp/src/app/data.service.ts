import { Product } from './Product';
import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";


@Injectable()
export class DataService{
    private url = "https://localhost:44371/api/products";

    constructor(private http: HttpClient){}
getProducts(){
    return this.http.get(this.url);
}
createProduct(product:Product){
    return this.http.post(this.url, product);
}

updateProduct(product:Product){
    return this.http.put(this.url + '/' +product.productId, product);
}

deleteProduct(id:number){
    return this.http.delete(this.url + '/' + id);
}

}
import { Component, OnInit } from '@angular/core';
import { DataService } from 'src/app/data.service';
import { Product } from 'src/app/Product';

@Component({
  selector: 'app-products-test',
  templateUrl: './products-test.component.html',
  providers: [DataService],
  styleUrls: ['./products-test.component.css']
})
export class ProductsTestComponent implements OnInit {

  product: Product = new Product();
  products:Product[];
  tableMode: boolean = true;
  constructor(private dataService: DataService) { }

  ngOnInit() {
    this.loadProducts();
    console.log("Products: ", this.products);
  }
  loadProducts() {
    this.dataService.getProducts()
        .subscribe((data: Product[]) => this.products = data);
}
editProduct(p: Product) {
  this.product = p;
}
showProds(){
  console.log("ASD",this.products)
}
save(){
  if(this.product.productId==null){
    this.dataService.createProduct(this.product)
    .subscribe((data:Product) =>this.products.push(data));
  }
  else{
    this.dataService.updateProduct(this.product)
    .subscribe(data=>this.loadProducts());
  }
  this.cancel();
}
cancel() {
  this.product = new Product();
  this.tableMode = true;
}
delete(p: Product) {
  this.dataService.deleteProduct(p.productId)
      .subscribe(data => this.loadProducts());
}
add() {
  this.cancel();
  this.tableMode = false;
}
}

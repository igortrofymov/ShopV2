import { Observable } from 'rxjs';
import { Product } from 'src/app/Product';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from 'src/app/services/product.service';
import { CategoryService } from 'src/app/services/Category.service';
import { Category } from 'src/app/Category';
import { NgForOf } from '@angular/common';

@Component({
  selector: 'app-product-list',
  templateUrl: './product-list.component.html',
  styleUrls: ['./product-list.component.css']
})
export class ProductListComponent implements OnInit {
 
  categories : Category[];
  allProducts : Product[];
  product: Product;
products: Product[];
tableMode: boolean = true;
filter:any={};

  constructor( private route: ActivatedRoute,
    private router: Router,
    private productService: ProductService, 
    private categoryService:CategoryService) { }

  ngOnInit() {
var sources = [
  this.categoryService.getCategories(),
  this.productService.getProducts(this.filter)
]

    Observable.forkJoin(sources).subscribe(data=>{
      this.categories  = data[0] as Category[];
      this.products = this.allProducts = data[1] as Product[];
      this.loadCategotyNames();
    }, err=>{
      if(err.status==404){
        this.router.navigate(['/home'])
      }
    });

    this.loadCategotyNames();
  }
  editProduct(p){
this.product = p;
  }
  saveEdit(){
    this.productService.update(this.product).subscribe(data=>{
      console.log(data+" was edited");
     
      this.product.categoryName = this.categories.filter(c=>c.id == this.product.categoryId)[0].name;
      this.products[this.product.productId] = this.product;
    })
    this.cancel();
  }

  updateCategoryName(id){
    this.categories[this.product.categoryId].name
  }
loadCategotyNames(){
  this.products.forEach(p => {
    this.categories.forEach(c=>{
      if(c.id==p.categoryId){
        p.categoryName = c.name;
      }
    })
});
}
cancel(){this.product = undefined;}

onFilterChange(){
  
  this.productService.getProducts(this.filter).subscribe(data=>{this.products = data as Product[];
    this.loadCategotyNames();});
  
}

resetFilter(){
  this.filter = {};
  this.onFilterChange();
}
}

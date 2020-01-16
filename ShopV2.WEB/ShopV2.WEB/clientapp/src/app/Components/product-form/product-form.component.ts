import { CategoryService } from './../../services/Category.service';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/Category';
import { Product } from 'src/app/Product';
import { ToastyService } from 'ng2-toasty';
import { ActivatedRoute, Router, ParamMap } from '@angular/router';
import { switchMap } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/forkJoin'
import { ConditionalExpr } from '@angular/compiler';

@Component({
  providers: [CategoryService],
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
categories : Category[];
product : Product ={productId:0,
};
products: Product[];
id: number;
product$: any;
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private productService: ProductService, 
    private categoryService:CategoryService, 
    private toastyService : ToastyService) {
     
route.params.subscribe(p=>{
  this.id = p['id'];
  this.product.productId= p['id'];
  console.log(this.product.productId+"  asdads")
})

     }

  ngOnInit() {
   if(this.product.productId)
   {
      this.productService.getProduct(this.product.productId).subscribe(data=>{
        this.product = data;
      });
    }
      this.loadCategories();
    
   // .subscribe(p=>{
     // this.product = p;
    //this.loadCategories();
  }

  loadCategories(){
    this.categoryService.getCategories().subscribe((data: Category[])=>{this.categories = data;
    })
  }
  onCatsChange(){
  var selectedCategory = this.categories.find(m=>m.id==this.product.categoryId);
  
  console.log("cat: ", selectedCategory)
  this.products = selectedCategory ? selectedCategory.products : [];
  }

  submit(){
    if(this.product.productId){
      this.productService.update(this.product)
      .subscribe(x=>{
        console.log(x);
      });
    }
    else{
    this.productService.create(this.product)
    .subscribe(
      x=>console.log(x));
    }
  }
  delete(){
    if(confirm("Are you sure?")){
      this.productService.delete(this.product.productId).subscribe(x=>{
        console.log(x);
      });
    }
  }
}

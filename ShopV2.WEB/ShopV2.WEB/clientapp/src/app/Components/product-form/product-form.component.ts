import { CategoryService } from './../../services/Category.service';
import { ProductService } from './../../services/product.service';
import { Component, OnInit } from '@angular/core';
import { Category } from 'src/app/Category';
import { Product } from 'src/app/Product';

@Component({
  providers: [CategoryService],
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
categories : Category[];
product : Product = new Product;
products: Product[];
  constructor(private productService: ProductService, private categoryService:CategoryService) { }

  ngOnInit() {
    this.loadCategories();
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

}

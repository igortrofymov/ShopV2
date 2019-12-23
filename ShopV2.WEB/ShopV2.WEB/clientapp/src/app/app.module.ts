

import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import { ProductService } from './services/product.service';

import { AppComponent } from './app.component';
import { ProductFormComponent } from './Components/product-form/product-form.component';

import { NavMenuComponent } from './Components/nav-menu/nav-menu.component';
import { ConfigComponent } from './config/config.component';
import { ProductsTestComponent } from './Components/products-test/products-test.component';

@NgModule({
  imports: [
    HttpClientModule,
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    RouterModule.forRoot([
      {path:'',redirectTo: 'home', pathMatch: 'full'},
      {path:'**', redirectTo: 'home'},
      {path: 'products/new', component: ProductFormComponent }
    ])
  ], 
   declarations: [
    ProductsTestComponent,
    ConfigComponent,
    AppComponent,
    NavMenuComponent,
    ProductFormComponent
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }

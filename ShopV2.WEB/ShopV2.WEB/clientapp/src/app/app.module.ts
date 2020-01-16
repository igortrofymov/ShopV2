
import { AppRoutingModule } from './app-routing.module';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { NgModule, ErrorHandler } from '@angular/core';
import {ToastyModule}  from 'ng2-toasty'

import { ProductService } from './services/product.service';

import { AppComponent } from './app.component';
import { ProductFormComponent } from './Components/product-form/product-form.component';

import { NavMenuComponent } from './Components/nav-menu/nav-menu.component';
import { ConfigComponent } from './config/config.component';
import { ProductsTestComponent } from './Components/products-test/products-test.component';
import { ProductListComponent } from './Components/product-list/product-list.component';
import { AppErrorHandler } from './app.error-handler';


const appRoutes: Routes =[
  {path: '', redirectTo: 'products/list', pathMatch:'full' },
  {path: 'products/new', component: ProductFormComponent },
  {path: 'products/list', component: ProductListComponent },
  {path: 'products/:id', component: ProductFormComponent, pathMatch:'full' }
];
@NgModule({
  imports: [
    HttpClientModule,
    ToastyModule.forRoot(),
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    RouterModule.forRoot(appRoutes
     )
  ], 
   declarations: [
    ProductsTestComponent,
    ConfigComponent,
    AppComponent,
    NavMenuComponent,
    ProductFormComponent,
    ProductListComponent
  ],
  providers: [
    {provide: ErrorHandler, useClass: AppErrorHandler},
    ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }

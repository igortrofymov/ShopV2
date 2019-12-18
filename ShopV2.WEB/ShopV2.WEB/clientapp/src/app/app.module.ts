import { RouterModule } from '@angular/router';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductFormComponent } from './Components/product-form/product-form.component';
import { ReactiveFormsModule } from '@angular/forms';
import { NavMenuComponent } from './Components/nav-menu/nav-menu.component';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      {path:'',redirectTo: 'home', pathMatch: 'full'},
      {path:'**', redirectTo: 'home'},
      {path: 'products/new', component: ProductFormComponent }
    ])
  ], 
   declarations: [
    AppComponent,
    NavMenuComponent,
    ProductFormComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

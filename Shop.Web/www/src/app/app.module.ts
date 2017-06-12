import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppComponent } from './app.component';
import 'hammerjs';
import { NavbarModule } from "app/navbar/navbar.module";
import { HeaderModule } from "app/header/header.module";
import { BooksModule } from './books/books.module'
import { AppRoutingModule } from "app/app-routing.module";
import { SharedModule } from "app/shared/shared.module";
import { MaterialModule } from "@angular/material";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";

@NgModule({
  declarations: [
      AppComponent
  ],
  imports: [
      BrowserModule,
      AppRoutingModule,
      NavbarModule,
      HeaderModule, 
      BooksModule,
      MaterialModule,
      BrowserAnimationsModule,
      SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

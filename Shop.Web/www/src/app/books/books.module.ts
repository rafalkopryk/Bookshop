import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from '@angular/material';
import { BooksRoutingModule } from './books-routing.module';
import { BooksComponent } from './books.component';
import { AudiobooksComponent } from './audiobooks.component';
import { EbooksComponent } from './ebooks.component';
import { BooksService } from './books.service'
import { MdDataTableModule } from 'ng2-md-datatable';
import { FormsModule } from '@angular/forms';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import 'hammerjs';
import { FlexLayoutModule } from '@angular/flex-layout';
import { AddToCartDialogComponent } from "./add-to-cart-dialog.component";
import { CarriersService } from './carriers.service';




@NgModule({
    imports: [
      MaterialModule,
      CommonModule,
      BooksRoutingModule,
      MdDataTableModule,
      FlexLayoutModule,
        BrowserAnimationsModule,
        FormsModule
  ],
    declarations: [BooksComponent, AudiobooksComponent, EbooksComponent, AddToCartDialogComponent],
  providers: [BooksService, CarriersService],
  entryComponents: [
      AddToCartDialogComponent
  ]
})
export class BooksModule { }

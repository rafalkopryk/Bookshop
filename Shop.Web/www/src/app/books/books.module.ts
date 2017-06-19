import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { BooksRoutingModule } from './books-routing.module';

import { BooksService } from './books.service'
import { MdDataTableModule } from 'ng2-md-datatable';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';


import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import 'hammerjs';
import { FlexLayoutModule } from '@angular/flex-layout';
import { CarriersService } from './carriers.service';
import { SharedModule } from "app/shared/shared.module";
import { MaterialModule } from "@angular/material";
import { AddToCartDialogComponent } from "app/books/add-to-cart-dialog/add-to-cart-dialog.component";
import { NoResultsAlertComponent } from './no-results-alert/no-results-alert.component';
import { BooksComponent } from './all/books.component';
import { NoveltiesComponent } from './novelties/novelties.component';
import { PreviewsComponent } from './previews/previews.component';
import { SuperBargainsComponent } from './super-bargains/super-bargains.component';
import { AudiobooksComponent } from "app/books/audiobooks/audiobooks.component";
import { EbooksComponent } from "app/books/ebooks/ebooks.component";
import { HttpModule }    from '@angular/http';


@NgModule({
    imports: [
        FormsModule,
        ReactiveFormsModule, 
        MaterialModule,
        CommonModule,
        BooksRoutingModule,
        MdDataTableModule,
        FlexLayoutModule,
        BrowserAnimationsModule, 
        HttpModule    
    ],
    declarations: [BooksComponent, AudiobooksComponent, EbooksComponent, AddToCartDialogComponent, NoResultsAlertComponent, NoveltiesComponent, PreviewsComponent, SuperBargainsComponent],
    providers: [BooksService, CarriersService],
    entryComponents: [
        AddToCartDialogComponent, NoResultsAlertComponent
    ]
})
export class BooksModule { }

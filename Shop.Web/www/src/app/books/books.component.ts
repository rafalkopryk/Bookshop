import { Component, EventEmitter, AfterViewInit, ViewChild} from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { BooksService } from './books.service'
import { Book } from './book'
import { MdDataTableComponent, IDatatableSortEvent, DatatableSortType} from 'ng2-md-datatable';
import 'rxjs/add/observable/from';
import { MdDialog, MdDialogRef } from '@angular/material';
import { AddToCartDialogComponent } from "./add-to-cart-dialog.component";


@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.scss']
})
export class BooksComponent implements AfterViewInit {

    currentSortBy: string | undefined;
    currentSortType = DatatableSortType.Ascending;
    books: Array<Book> = [];
    selectedOption: string;
    @ViewChild(MdDataTableComponent) datatable: MdDataTableComponent;

    constructor(private booksService: BooksService, public dialog: MdDialog) {}


    ngAfterViewInit() {
        this.getBooks();

        Observable.from(this.datatable.sortChange)
            .subscribe((e: IDatatableSortEvent) => this.getBooks(e.sortBy, e.sortType));
    }

    private getBooks(sortBy: string | undefined = this.currentSortBy, sortType: DatatableSortType = this.currentSortType){
        this.currentSortBy = sortBy;
        this.currentSortType = sortType;
        this.books = this.booksService.findBooks();
    }

    openDialog(book:Book) {
        let dialogRef = this.dialog.open(AddToCartDialogComponent, {
            data: book
        });
        //dialogRef.afterClosed().subscribe(result => {
        //    console.log(result);
        //});
    }
    
}

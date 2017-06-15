import { Component, EventEmitter, ViewChild, TemplateRef, OnInit, OnDestroy} from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { BooksService } from '../books.service'
import { Book } from '../book'
import { MdDataTableComponent, IDatatableSortEvent, DatatableSortType} from 'ng2-md-datatable';
import 'rxjs/add/observable/from';
import { MdDialog, MdDialogRef, MdDialogConfig, MD_DIALOG_DATA } from '@angular/material';
import { DOCUMENT } from '@angular/platform-browser';
import { SearchService } from "app/shared/search.service";
import { AddToCartDialogComponent } from "app/books/add-to-cart-dialog/add-to-cart-dialog.component";
import { NoResultsAlertComponent } from "app/books/no-results-alert/no-results-alert.component";
import { Subscription } from "rxjs/Subscription";



@Component({
  selector: 'app-books',
  templateUrl: '../books.component.html',
  styleUrls: ['../books.component.scss']
})
export class BooksComponent implements OnInit, OnDestroy {
       


    query: string;
    currentSortBy: string | undefined;
    currentSortType = DatatableSortType.Ascending;
    books: Array<Book> = [];
    subscription: Subscription;

    @ViewChild(MdDataTableComponent)
    private dataTable: MdDataTableComponent;

    constructor(
        private booksService: BooksService,
        public dialog: MdDialog,
        private searchService: SearchService
    ) { }

    ngOnInit() {
        this.getBooks(this.currentSortBy, this.currentSortType,this.query);
    
        this.subscription = this.searchService.query$.subscribe(
            query => {
                this.query = query;
                this.getBooks(this.currentSortBy, this.currentSortType, this.query);
            }
        );

        Observable.from(this.dataTable.sortChange)
            .subscribe((e: IDatatableSortEvent) => this.getBooks(e.sortBy, e.sortType, this.query));
    }

    ngOnDestroy() {
        this.subscription.unsubscribe();
    }


    private getBooks(sortBy: string | undefined = this.currentSortBy, sortType: DatatableSortType = this.currentSortType, query?: string) {
        this.currentSortBy = sortBy;
        this.currentSortType = sortType;
        let books = this.booksService.findBooks(query);
        if (!books.length)
            this.dialog.open(NoResultsAlertComponent, { role: "alertdialog", width: "300px"});
        else
           this.books = books;
    }

    openDialog(book:Book) {
        this.dialog.open(AddToCartDialogComponent, {data: book});
    }
    
}

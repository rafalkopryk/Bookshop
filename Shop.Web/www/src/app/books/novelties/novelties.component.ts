import { Component, OnInit } from '@angular/core';
import { BooksComponent } from "app/books/all/books.component";
import { BooksService } from "app/books/books.service";
import { MdDialog } from "@angular/material";
import { SearchService } from "app/shared/search.service";
import { DatatableSortType } from "ng2-md-datatable";
import { NoResultsAlertComponent } from "app/books/no-results-alert/no-results-alert.component";

@Component({
  selector: 'app-novelties',
  templateUrl: '../books.component.html',
  styleUrls: ['../books.component.scss']
})
export class NoveltiesComponent extends BooksComponent implements OnInit {

  constructor(protected booksService: BooksService,public dialog: MdDialog,protected searchService: SearchService) { 
      super(booksService,dialog,searchService);
    }

    getBooks(sortBy: string = this.currentSortBy, sortType: DatatableSortType = this.currentSortType, query?: string) {
        this.currentSortBy = sortBy;
        this.currentSortType = sortType;

        let orderBy = this.currentSortType == DatatableSortType.Descending ? this.currentSortBy+"_desc" : this.currentSortBy;

        this.booksService.getNovelties(query,orderBy).subscribe(
            response =>{
                if (!response.length)
                    this.dialog.open(NoResultsAlertComponent, { role: "alertdialog", width: "300px"});
                else
                    this.books = response;
            }
        );
    }

}

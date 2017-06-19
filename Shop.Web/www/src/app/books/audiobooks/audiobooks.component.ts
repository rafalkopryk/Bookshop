import { Component, EventEmitter, ViewChild, TemplateRef, OnInit, OnDestroy} from '@angular/core';
import { BooksService } from '../books.service'
import { MdDataTableComponent, IDatatableSortEvent, DatatableSortType} from 'ng2-md-datatable';
import 'rxjs/add/observable/from';
import { MdDialog } from '@angular/material';
import { SearchService } from "app/shared/search.service";
import { NoResultsAlertComponent } from "app/books/no-results-alert/no-results-alert.component";
import { BooksComponent } from "../all/books.component"

@Component({
  selector: 'app-audiobooks',
  templateUrl: '../books.component.html',
  styleUrls: ['../books.component.scss']
})
export class AudiobooksComponent extends BooksComponent  {

    constructor(protected booksService: BooksService,public dialog: MdDialog,protected searchService: SearchService) { 
      super(booksService,dialog,searchService);
    }

    getBooks(sortBy: string = this.currentSortBy, sortType: DatatableSortType = this.currentSortType, query?: string) {
        this.currentSortBy = sortBy;
        this.currentSortType = sortType;

        let orderBy = this.currentSortType == DatatableSortType.Descending ? this.currentSortBy+"_desc" : this.currentSortBy;

        this.booksService.getAudiobooks(query,orderBy).subscribe(
            response =>{
                if (!response.length)
                    this.dialog.open(NoResultsAlertComponent, { role: "alertdialog", width: "300px"});
                else
                    this.books = response;
            }
        );
    }
}

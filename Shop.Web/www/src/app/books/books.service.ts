import { Injectable } from '@angular/core';
import { DatatableSortType } from "ng2-md-datatable";
import { Book } from "app/books/book";
import { Http, Response, RequestOptions, URLSearchParams  } from "@angular/http";
import { Observable } from 'rxjs/Rx';

@Injectable()
export class BooksService {

    private resourceUrl  = 'http://localhost:63714/api/books';
    private requestOptions: RequestOptions;

    constructor(private http: Http) {
        this.requestOptions = new RequestOptions();
    }

    getBooks(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/all", this.requestOptions)
            .map(this.extractData)
    }

    getEbooks(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/ebooks", this.requestOptions)
            .map(this.extractData)
    }

    getAudiobooks(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/audiobooks", this.requestOptions)
            .map(this.extractData)
    }

    getNovelties(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/novelties", this.requestOptions)
            .map(this.extractData)
    }

    getPreviews(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/previews", this.requestOptions)
            .map(this.extractData)
    }

    getSuperBargains(query?: string, sortBy?: string, sortType?: DatatableSortType): Observable<Book[]> {   
        this.setRequestParametrs(query,sortBy,sortType);
        return this.http.get(this.resourceUrl + "/super-bargains", this.requestOptions)
            .map(this.extractData)
    }

    private extractData(res: Response) {
        return <Book[]>res.json();
    }

    private setRequestParametrs(query?: string, sortBy?: string, sortType?: DatatableSortType) {
        let params: URLSearchParams = new URLSearchParams();
        params.set('query', query);
        params.set('sortBy', sortBy);
        params.set('sortType', sortType.toString());
        this.requestOptions.params = params;
    }  
}

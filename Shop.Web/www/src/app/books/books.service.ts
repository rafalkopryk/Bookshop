import { Injectable } from '@angular/core';
import { DatatableSortType } from "ng2-md-datatable";
import { Book } from "app/books/book";
import { Http, Response, RequestOptions, URLSearchParams  } from "@angular/http";
import { Observable } from 'rxjs/Rx';
import { ProgressService } from 'app/shared/progress/progress.service'

@Injectable()
export class BooksService {

    private resourceUrl  = '/api/books';
    private requestOptions: RequestOptions;

    constructor(private http: Http,private progressService: ProgressService) {
        this.requestOptions = new RequestOptions();
    }

    getBooks(query?: string, orderBy?: string): Observable<any> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/all", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    getEbooks(query?: string, orderBy?: string): Observable<Book[]> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/ebooks", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    getAudiobooks(query?: string, orderBy?: string): Observable<Book[]> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/audiobooks", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    getNovelties(query?: string,  orderBy?: string): Observable<Book[]> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/novelties", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    getPreviews(query?: string,  orderBy?: string): Observable<Book[]> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/previews", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    getSuperBargains(query?: string,  orderBy?: string): Observable<Book[]> {   
        this.setRequestParametrs(query,orderBy);
        this.showProgress();
        return this.http.get(this.resourceUrl + "/super-bargains", this.requestOptions)
            .map(this.extractData)
            .finally(() => {
                this.hideProgress();
            });
    }

    private extractData(res: Response) {
        return <Book[]>res.json();
    }


    private setRequestParametrs(query?: string, orderBy?: string) {
        let params: URLSearchParams = new URLSearchParams();
        params.set('query', query);
        params.set('orderBy', orderBy);
        this.requestOptions.params = params;
    }

    private showProgress(): void {
        this.progressService.show();
    }

    private hideProgress(): void {
        this.progressService.hide();
    }
    

}

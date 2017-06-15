import { Injectable } from '@angular/core';
import { Subject } from "rxjs/Subject";

@Injectable()
export class SearchService {

    
    private querySource = new Subject<string>();
    query$ = this.querySource.asObservable();

    addQuery(value: string) {
        this.querySource.next(value);
    }

}

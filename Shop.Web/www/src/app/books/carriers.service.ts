import { Injectable } from '@angular/core';
import { Carrier } from "./carrier";
import { Http} from "@angular/http";
import { Observable } from 'rxjs/Rx';
import { Subscription } from "rxjs/Subscription";

@Injectable()
export class CarriersService {
    
    private resourceUrl  = 'http://localhost:63714/api/carriers';
    constructor(private http: Http) {}

    getCarriers(): Observable<Carrier[]> {
        return this.http.get(this.resourceUrl)
            .map(response => <Carrier[]>response.json());
    }
}

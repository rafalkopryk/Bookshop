import { Injectable } from '@angular/core';
import { Subject } from "rxjs/Subject";
import { BasketItem } from "app/basket/basket-item";

@Injectable()
export class BasketService {

    private elementsSource = new Subject<BasketItem>();
    elements$ = this.elementsSource.asObservable();

    addItem(value: BasketItem) {
        this.elementsSource.next(value);
    }
}

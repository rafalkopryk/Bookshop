import { Component, OnInit } from '@angular/core';
import { BasketService } from "app/shared/basket.service";
import { BasketItem } from "app/books/basket-item";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

    basket: Array<BasketItem> = [];
    numberOfItemsInBasket: number;
    list: number[];
    constructor(private basketService: BasketService) {
       
    }

    ngOnInit() {
        this.basket = [];
        this.numberOfItemsInBasket = 0;
        this.basketService.elements$.subscribe(item => {
            console.log(this.basket);
            this.basket.push(item);
            this.numberOfItemsInBasket = this.countAllElements();
        })
        
    }

    private countAllElements(): number {
        let result: number = 0;
        this.basket.forEach(item => result += item.quantity);
        return result;
    }


}

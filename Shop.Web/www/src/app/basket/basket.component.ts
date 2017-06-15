import { Component, OnInit } from '@angular/core';
import { BasketItem } from "app/basket/basket-item";
import { BasketService } from "app/shared/basket.service";

@Component({
  selector: 'app-basket',
  templateUrl: './basket.component.html',
  styleUrls: ['./basket.component.scss']
})
export class BasketComponent implements OnInit {
  
  basket: Array<BasketItem> = [];

  constructor(private basketService: BasketService) { }

  ngOnInit() {
      this.basket = [];
      this.basketService.elements$.subscribe(item => {
          this.basket.push(item);
      })    
  }

}

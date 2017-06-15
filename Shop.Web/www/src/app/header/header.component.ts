import { Component, OnInit } from '@angular/core';
import { BasketService } from "app/shared/basket.service";
import { BasketItem } from "app/basket/basket-item";
import { SidenavService } from "app/shared/sidenav.service";

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {

    numberOfItemsInBasket: number;
    searchBar: boolean;

    constructor(private basketService: BasketService, private sidenavService:SidenavService) { }

    ngOnInit() {
        this.searchBar = false;
        this.numberOfItemsInBasket = 0;
        this.basketService.elements$.subscribe(item => {
            this.numberOfItemsInBasket += item.quantity;
        }) 
    }

    toggleSidenav() {
        this.sidenavService.toggle();
    }

    toggleSearchbar() {
        this.searchBar=!this.searchBar;
    }
}

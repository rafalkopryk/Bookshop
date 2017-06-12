﻿import { Component, Inject, OnInit} from '@angular/core';
import { MdDialog, MdDialogRef, MdDialogConfig, MD_DIALOG_DATA } from '@angular/material';
import { Carrier } from "app/books/carrier";
import { CarriersService } from "app/books/carriers.service";
import { FormControl, Validators, FormBuilder, FormGroup } from '@angular/forms';
import { BasketItem } from "app/books/basket-item";
import { Book } from "app/books/book";
import { BasketService } from "app/shared/basket.service";


@Component({
    selector: 'app-add-to-cart-dialog',
    templateUrl: './add-to-cart-dialog.component.html',
    styleUrls: ['./add-to-cart-dialog.component.scss']
})
export class AddToCartDialogComponent implements OnInit {
        
    basketItem: BasketItem;
    carriers: Array<Carrier> = [];
    form: FormGroup;
    
    constructor(
        public dialogRef: MdDialogRef<AddToCartDialogComponent>,
        private carriersService: CarriersService,
        @Inject(MD_DIALOG_DATA) public data: Book,
        private formBuilder: FormBuilder,
        private basketService: BasketService
    ) { }

    ngOnInit(): void {
        this.carriers = this.carriersService.getAllCarriers();
        this.basketItem = new BasketItem(this.data, 1);
        this.buildForm();
    }


    addToCart() {
        this.basketService.addItem(this.basketItem);
        this.dialogRef.close();
    }

    private buildForm() {
        this.form = this.formBuilder.group({
            'title': [{ value: this.basketItem.book.Title, disabled: true }],
            'quantity': [this.basketItem.quantity, [
                Validators.required
            ]],
            'carrier': ['', Validators.required]
        });

        this.form.valueChanges.subscribe(data => {
            this.basketItem.carrier = data.carrier;
            this.basketItem.quantity = data.quantity;
        })
    }
}
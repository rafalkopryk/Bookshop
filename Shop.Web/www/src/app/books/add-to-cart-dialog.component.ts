import { Component, Inject} from '@angular/core';
import { MdDialog, MdDialogRef, MdDialogConfig, MD_DIALOG_DATA } from '@angular/material';
import { Carrier } from "app/books/carrier";
import { CarriersService } from "app/books/carriers.service";

@Component({
    selector: 'app-add-to-cart-dialog',
    templateUrl: './add-to-cart-dialog.component.html',
    styleUrls: ['./add-to-cart-dialog.component.scss']
})
export class AddToCartDialogComponent {
    title: string ='';
    selectedCarrier: string;
    quantity: number;
    carriers: Array<Carrier> = [];

    constructor(public dialogRef: MdDialogRef<AddToCartDialogComponent>, private carriersService: CarriersService, @Inject(MD_DIALOG_DATA) public data: any) {
        this.carriers = this.carriersService.getAllCarriers();
        this.title = this.data.title;
    }
  
    

}

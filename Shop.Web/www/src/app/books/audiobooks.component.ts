import { Component} from '@angular/core';
import { CarriersService } from "app/books/carriers.service";
import { Carrier } from "app/books/carrier";
import { FormControl, Validators } from '@angular/forms';

@Component({
  selector: 'app-audiobooks',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.scss']
})
export class AudiobooksComponent {

    constructor(private carriersService: CarriersService) { }

    carriers: Array<Carrier> = this.carriersService.getAllCarriers();

}

import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

    tabLinks = [];

    constructor() { }

    ngOnInit(): void {
        this.tabLinks = [
            { label: 'Wszystkie', link: 'books' },
            { label: 'Audiobooki', link: 'audiobooks' },
            { label: 'E-Booki', link: 'ebooks' }
        ]
     }

}

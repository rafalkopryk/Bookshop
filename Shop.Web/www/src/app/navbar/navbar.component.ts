import { Component, OnInit, ViewChild } from '@angular/core';
import { Router } from "@angular/router";
import { MdTabGroup } from "@angular/material";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

    navLinks = [];

    @ViewChild('nav') nav: MdTabGroup;

    constructor(private router: Router) { }

    ngOnInit() {

        

        //this.router.url

        this.navLinks = [
            { label: 'Wszystkie', link: 'books' },
            { label: 'Audiobooki', link: 'audiobooks' },
            { label: 'E-Booki', link: 'ebooks' },
            { label: 'Nowości', link: 'novelties' },
            { label: 'Zapowiedzi', link: 'previews' },
            { label: 'Super okazje', link: 'super-bargains' }
        ]

        
    }

    onTabChange(tabIndex) {
        this.router.navigateByUrl(this.navLinks[tabIndex].link);
    }
}

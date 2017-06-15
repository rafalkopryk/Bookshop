import { Component, ViewChild } from '@angular/core';
import { MdSidenav } from "@angular/material";
import { SidenavService } from "app/shared/sidenav.service";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
    @ViewChild('sidenav') sidenav: MdSidenav;

    constructor(private sidenavService: SidenavService) { }

    ngOnInit() {
        this.sidenavService.setSidenav(this.sidenav);
    }
}

import { Injectable } from '@angular/core';
import { MdSidenav, MdSidenavToggleResult } from "@angular/material";

@Injectable()
export class SidenavService {

    private sidenav: MdSidenav;

    public setSidenav(sidenav: MdSidenav) {
        this.sidenav = sidenav;
    }

    public toggle(): Promise<MdSidenavToggleResult>{
        return this.sidenav.toggle();
    }

}

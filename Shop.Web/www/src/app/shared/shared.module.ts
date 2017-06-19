import { NgModule } from '@angular/core';
import { BasketService } from "app/shared/basket.service";
import { SidenavService } from "app/shared/sidenav.service";
import { SearchService } from "app/shared/search.service";
import { PreloaderService } from "app/shared/preloader.service";

@NgModule({
  imports: [
  ],
  declarations: [],
  providers: [BasketService,SidenavService,SearchService,PreloaderService],

})
export class SharedModule { }

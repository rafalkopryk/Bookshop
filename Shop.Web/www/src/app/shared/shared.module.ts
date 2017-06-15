import { NgModule } from '@angular/core';
import { BasketService } from "app/shared/basket.service";
import { SidenavService } from "app/shared/sidenav.service";
import { SearchService } from "app/shared/search.service";

@NgModule({
  imports: [
  ],
  declarations: [],
  providers: [BasketService,SidenavService,SearchService],
})
export class SharedModule { }

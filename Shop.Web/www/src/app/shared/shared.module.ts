import { NgModule } from '@angular/core';
import { BasketService } from "app/shared/basket.service";
import { SidenavService } from "app/shared/sidenav.service";
import { SearchService } from "app/shared/search.service";
import { ProgressService } from "app/shared/progress/progress.service";
import { ProgressComponent } from './progress/progress.component';
import { MaterialModule } from '@angular/material';

@NgModule({
  imports: [
    MaterialModule
  ],
  declarations: [ProgressComponent],
  providers: [BasketService,SidenavService,SearchService,ProgressService],
  exports: [ProgressComponent]

})
export class SharedModule { }

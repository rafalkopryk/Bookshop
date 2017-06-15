import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './header.component';
import { MaterialModule } from "@angular/material";
import { FlexLayoutModule } from "@angular/flex-layout";
import { SharedModule } from "app/shared/shared.module";
import 'hammerjs';
import { SearchEngineComponent } from './search-engine/search-engine.component';
import { FormsModule } from "@angular/forms";

@NgModule({
  imports: [
     CommonModule,
     MaterialModule,
      FlexLayoutModule,
      FormsModule
      
    ],
  declarations: [HeaderComponent, SearchEngineComponent],
  providers: [],
  exports: [HeaderComponent]
})
export class HeaderModule { }

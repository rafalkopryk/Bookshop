import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BasketComponent } from './basket.component';
import { MaterialModule } from "@angular/material";
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { FlexLayoutModule } from "@angular/flex-layout";

@NgModule({
  imports: [
      CommonModule,
      MaterialModule,
      BrowserAnimationsModule,
      FlexLayoutModule
  ],
  declarations: [BasketComponent],
  exports: [BasketComponent]
})
export class BasketModule { }

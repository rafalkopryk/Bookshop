import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BooksComponent } from './books.component';
import { EbooksComponent } from './ebooks.component';
import { AudiobooksComponent } from './audiobooks.component';


const routes: Routes = [
    { path: 'books', component: BooksComponent },
    { path: 'audiobooks', component: AudiobooksComponent },
    { path: 'ebooks', component: EbooksComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BooksRoutingModule { }

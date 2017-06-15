import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { BooksComponent } from "app/books/all/books.component";
import { EbooksComponent } from "app/books/ebooks/ebooks.component";
import { AudiobooksComponent } from "app/books/audiobooks/audiobooks.component";
import { NoveltiesComponent } from "app/books/novelties/novelties.component";
import { PreviewsComponent } from "app/books/previews/previews.component";
import { SuperBargainsComponent } from "app/books/super-bargains/super-bargains.component";



const routes: Routes = [
    { path: 'books', component: BooksComponent },
    { path: 'audiobooks', component: AudiobooksComponent },
    { path: 'ebooks', component: EbooksComponent },
    { path: 'novelties', component: NoveltiesComponent },
    { path: 'previews', component: PreviewsComponent },
    { path: 'super-bargains', component: SuperBargainsComponent }
   
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class BooksRoutingModule { }

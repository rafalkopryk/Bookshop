import { Injectable } from '@angular/core';
import { DatatableSortType } from "ng2-md-datatable";
import { Book } from "app/books/book";

@Injectable()
export class BooksService {

    books: Array<Book>;



    public findBooks(query?: string, sortBy?: string, sortType?: DatatableSortType): Array<Book> {
        let books = this.books.filter(book => (book.Title.startsWith(query) || query == null) || (book.Author.startsWith(query) || query == null));
        return books;
    }

    constructor() {

        this.books = [
            new Book(1, 'Władca Pierscienia', new Date(),32,'Jan Kowalski','Zak'),
            new Book(2, 'Władca Pierscienia1', new Date(), 32, 'Jan Kowalski', 'Zak'),
            new Book(3, 'Władca Pierscienia2', new Date(), 32, 'Jan Kowalski', 'Zak')
        ]

    }

}

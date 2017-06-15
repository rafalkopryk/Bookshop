import { Book } from "app/books/book";
import { Carrier } from "app/books/carrier";

export class BasketItem {
    book: Book;
    carrier: Carrier;
    quantity: number;

    constructor(book: Book, quantity: number, carrier: Carrier) {
        this.book = book;
        this.quantity = quantity;
        this.carrier = carrier;
    }
    
}

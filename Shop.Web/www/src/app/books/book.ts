export class Book {
    BookId: number;
    Title: string;
    ReleaseDate: Date;
    Price: number;
    Author: string;
    Publisher: string;


    constructor(bookId: number, title: string, releaseDate: Date, price: number, author: string, publisher: string) {
        this.BookId = bookId;
        this.Title = title;
        this.ReleaseDate = releaseDate;
        this.Price = price;
        this.Author = author;
        this.Publisher = publisher;
    }
}

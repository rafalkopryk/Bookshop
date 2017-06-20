namespace Shop.DAL.Migrations
{
    using Shop.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Shop.DAL.ShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Shop.DAL.ShopDbContext context)
        {
            //Carriers

            context.Carriers.AddOrUpdate(x => x.CarrierId,
                new Carrier() { CarrierId = 1, Name = "PenDrive" },
                new Carrier() { CarrierId = 2, Name = "p³yta CD" },
                new Carrier() { CarrierId = 3, Name = "p³yta DVD" }
            );

            //Publishers
            context.Publishers.AddOrUpdate(x => x.PublisherId,
                new Publisher() { PublisherId = 1, Name = "Insignis" },
                new Publisher() { PublisherId = 2, Name = "Albatros" },
                new Publisher() { PublisherId = 3, Name = "W.A.B." },
                new Publisher() { PublisherId = 4, Name = "Prószyñski Media" },
                new Publisher() { PublisherId = 5, Name = "Zysk i S-ka" },
                new Publisher() { PublisherId = 6, Name = "Akurat" },
                new Publisher() { PublisherId = 7, Name = "Burda Publishing Polska" }

            );

            //Authors
            context.Authors.AddOrUpdate(x => x.AuthorId,
                new Author() { AuthorId = 1, FirstName = "George", LastName = "Martin" },
                new Author() { AuthorId = 2, FirstName = "Stephen", LastName = "King" },
                new Author() { AuthorId = 3, FirstName = "Walter", LastName = "Isaacson" },
                new Author() { AuthorId = 4, FirstName = "El¿bieta", LastName = "Chereziñska" },
                new Author() { AuthorId = 5, FirstName = "Katarzyna", LastName = "Puzyñska" },
                new Author() { AuthorId = 6, FirstName = "Paulina", LastName = "Œwist" },
                new Author() { AuthorId = 7, FirstName = "Anna", LastName = "Lewandowska" },
                new Author() { AuthorId = 8, FirstName = "Jay", LastName = "Asher" },
                new Author() { AuthorId = 9, FirstName = "Gillian", LastName = "Flynn" },
                new Author() { AuthorId = 10, FirstName = "Dan", LastName = "Brown" }
            );

            //Books
            context.Books.AddOrUpdate(x => x.BookId,
                //E-Books
                new Book() { BookId = 1, Title = "Einstein. Jego ¿ycie, jego wszechœwiat", ReleaseDate = DateTime.Parse("2014-04-02"), AuthorId = 2L, PublisherId = 3L, Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { BookId = 2, Title = "Steve Jobs", AuthorId = 3, PublisherId = 1, ReleaseDate = DateTime.Parse("2011-11-18"), Price = 36.44f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { BookId = 3, Title = "Lœnienie", AuthorId = 2, PublisherId = 4, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { BookId = 4, Title = "Bezsennoœæ", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2012-03-28"), Price = 31f, Type = TypeOfBook.EBook },
                new Book() { BookId = 5, Title = "Zielona mila", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 28.5f, Type = TypeOfBook.EBook },
                new Book() { BookId = 6, Title = "Pieœñ Lodu i Ognia. Tom 2. Starcie królów", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2012-04-03"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { BookId = 7, Title = "Pieœñ Lodu i Ognia. Tom 3. Nawa³nica mieczy. Czeœæ 1. Stal i œnieg", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2013-02-04"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { BookId = 8, Title = "Pieœñ Lodu i Ognia. Tom 3. Nawa³nica mieczy. Czêœæ 2. Krew i z³oto", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2014-04-07"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { BookId = 9, Title = "Zaginiony symbol", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-12-22"), Price = 30f, Type = TypeOfBook.EBook },

                //Audiobooks
                new Book() { BookId = 10, Title = "Pieœñ Lodu i Ognia. Tom 1. Gra o tron", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2015-12-17"), Price = 49.49f, Type = TypeOfBook.Audiobook },
                new Book() { BookId = 11, Title = "Pan Mercedes", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2014-09-01"), Price = 34.49f, Type = TypeOfBook.Audiobook },
                new Book() { BookId = 12, Title = "Zaginiona dziewczyna", AuthorId = 9, PublisherId = 7, ReleaseDate = DateTime.Parse("2014-10-08"), Price = 34.90f, Type = TypeOfBook.Audiobook },
                new Book() { BookId = 13, Title = "Inferno", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2013-10-26"), Price = 29.99f, Type = TypeOfBook.Audiobook },
                new Book() { BookId = 14, Title = "Anio³y i demony", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-01-21"), Price = 31.49f, Type = TypeOfBook.Audiobook },

                //Previews
                new Book() { BookId = 15, Title = "Odrodzone Królestwo. Tom 3. P³omienna korona", AuthorId = 4, PublisherId = 5, ReleaseDate = DateTime.Now.AddDays(7), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { BookId = 16, Title = "Prokurator", AuthorId = 6, PublisherId = 6, ReleaseDate = DateTime.Now.AddDays(10), Price = 34.9f, Type = TypeOfBook.EBook },
                new Book() { BookId = 17, Title = "Healthy mama. Poradnik zdrowej mamy", AuthorId = 7, PublisherId = 7, ReleaseDate = DateTime.Now.AddDays(11), Price = 49.9f, Type = TypeOfBook.EBook },

                //Novelties
                new Book() { BookId = 18, Title = "Odrodzone Królestwo. Tom 3. P³omienna korona", AuthorId = 5, PublisherId = 4, ReleaseDate = DateTime.Now.AddDays(-7), Price = 38f, Type = TypeOfBook.EBook },
                new Book() { BookId = 19, Title = "13 powodów", AuthorId = 8, PublisherId = 1, ReleaseDate = DateTime.Now.AddDays(-2), Price = 34.49f, SuperBargain = true, Type = TypeOfBook.Audiobook }
            );
        }
    }
}

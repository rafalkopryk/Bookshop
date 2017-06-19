using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL
{
    class ShopDbInitializer: CreateDatabaseIfNotExists<ShopDbContext>
    {
        protected override void Seed(ShopDbContext context)
        {
            //Carriers
            IEnumerable<Carrier> Carriers = new List<Carrier>
            {
                new Carrier() { Name="PenDrive"},
                new Carrier() { Name = "płyta CD" },
                new Carrier() { Name = "płyta DVD" }
            };
            context.Carriers.AddRange(Carriers);

            //Publishers
            IEnumerable<Publisher> publishers = new List<Publisher>
            {
                new Publisher() { Name = "Insignis" },
                new Publisher() { Name = "Albatros" },
                new Publisher() { Name = "W.A.B." },
                new Publisher() { Name = "Prószyński Media" },
                new Publisher() { Name = "Zysk i S-ka" },
                new Publisher() { Name = "Akurat" },
                new Publisher() { Name = "Burda Publishing Polska" }

            };
            context.Publishers.AddRange(publishers);

            //Authors
            IEnumerable<Author> authors = new List<Author>
            {
                new Author() { FirstName = "George", LastName = "Martin" },
                new Author() { FirstName = "Stephen", LastName = "King" },
                new Author() { FirstName = "Walter", LastName = "Isaacson" },
                new Author() { FirstName = "Elżbieta", LastName = "Cherezińska" },
                new Author() { FirstName = "Katarzyna", LastName = "Puzyńska" },
                new Author() { FirstName = "Paulina", LastName = "Świst" },
                new Author() { FirstName = "Anna", LastName = "Lewandowska" },
                new Author() { FirstName = "Jay", LastName = "Asher" },
                new Author() { FirstName = "Gillian", LastName = "Flynn" },
                new Author() { FirstName = "Dan", LastName = "Brown" }
            };
            context.Authors.AddRange(authors);
            context.SaveChanges();

            //Books
            IEnumerable<Book> books = new List<Book>
            {
                //E-Books
                new Book() { Title = "Einstein. Jego życie, jego wszechświat", ReleaseDate = DateTime.Parse("2014-04-02"),AuthorId=2L,PublisherId=1L ,Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { Title = "Steve Jobs", AuthorId = 3, PublisherId = 1, ReleaseDate = DateTime.Parse("2011-11-18"), Price = 36.44f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { Title = "Lśnienie", AuthorId = 2, PublisherId = 4, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook },
                new Book() { Title = "Bezsenność", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2012-03-28"), Price = 31f, Type = TypeOfBook.EBook },
                new Book() { Title = "Zielona mila", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 28.5f, Type = TypeOfBook.EBook },
                new Book() { Title = "Pieśń Lodu i Ognia. Tom 2. Starcie królów", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2012-04-03"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { Title = "Pieśń Lodu i Ognia. Tom 3. Nawałnica mieczy. Cześć 1. Stal i śnieg", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2013-02-04"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { Title = "Pieśń Lodu i Ognia. Tom 3. Nawałnica mieczy. Część 2. Krew i złoto", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2014-04-07"), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { Title = "Zaginiony symbol", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-12-22"), Price = 30f, Type = TypeOfBook.EBook },

                //Audiobooks
                new Book() { Title = "Pieśń Lodu i Ognia. Tom 1. Gra o tron", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2015-12-17"), Price = 49.49f, Type = TypeOfBook.Audiobook },
                new Book() { Title = "Pan Mercedes", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2014-09-01"), Price = 34.49f, Type = TypeOfBook.Audiobook },
                new Book() { Title = "Zaginiona dziewczyna", AuthorId = 9, PublisherId = 7, ReleaseDate = DateTime.Parse("2014-10-08"), Price = 34.90f, Type = TypeOfBook.Audiobook },
                new Book() { Title = "Inferno", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2013-10-26"), Price = 29.99f, Type = TypeOfBook.Audiobook },
                new Book() { Title = "Anioły i demony", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-01-21"), Price = 31.49f, Type = TypeOfBook.Audiobook },

                //Previews
                new Book() { Title = "Odrodzone Królestwo. Tom 3. Płomienna korona", AuthorId = 4, PublisherId = 5, ReleaseDate = DateTime.Now.AddDays(7), Price = 49f, Type = TypeOfBook.EBook },
                new Book() { Title = "Prokurator", AuthorId = 6, PublisherId = 6, ReleaseDate = DateTime.Now.AddDays(10), Price = 34.9f, Type = TypeOfBook.EBook },
                new Book() { Title = "Healthy mama. Poradnik zdrowej mamy", AuthorId = 7, PublisherId = 7, ReleaseDate = DateTime.Now.AddDays(11), Price = 49.9f, Type = TypeOfBook.EBook },

                //Novelties
                new Book() { Title = "Odrodzone Królestwo. Tom 3. Płomienna korona", AuthorId = 5, PublisherId = 4, ReleaseDate = DateTime.Now.AddDays(-7), Price = 38f, Type = TypeOfBook.EBook },
                new Book() { Title = "13 powodów", AuthorId = 8, PublisherId = 1, ReleaseDate = DateTime.Now.AddDays(-2), Price = 34.49f, SuperBargain = true, Type = TypeOfBook.Audiobook }
            };
            context.Books.AddRange(books);
            context.SaveChanges();


        }
    }
}

using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Web.Tests
{
    class TestHelper
    {
        public class DataInitializer
        {

          
            public static List<Book> GetAllBooks()
            {

                var publishers = new List<Publisher>
                {
                    new Publisher() { PublisherId=1 ,Name = "Insignis" },
                    new Publisher() { PublisherId=2 ,Name = "Albatros" },
                    new Publisher() { PublisherId=3 ,Name = "W.A.B." },
                    new Publisher() { PublisherId=4 ,Name = "Prószyński Media" },
                    new Publisher() { PublisherId=5 ,Name = "Zysk i S-ka" },
                    new Publisher() { PublisherId=6 ,Name = "Akurat" },
                    new Publisher() { PublisherId=7 ,Name = "Burda Publishing Polska" }
                };

                var authors = new List<Author>
                {
                    new Author() { AuthorId=1 ,FirstName = "George", LastName = "Martin" },
                    new Author() { AuthorId=2 ,FirstName = "Stephen", LastName = "King" },
                    new Author() { AuthorId=3 ,FirstName = "Walter", LastName = "Isaacson" },
                    new Author() { AuthorId=4 ,FirstName = "Elżbieta", LastName = "Cherezińska" },
                    new Author() { AuthorId=5 ,FirstName = "Katarzyna", LastName = "Puzyńska" },
                    new Author() { AuthorId=6 ,FirstName = "Paulina", LastName = "Świst" },
                    new Author() { AuthorId=7 ,FirstName = "Anna", LastName = "Lewandowska" },
                    new Author() { AuthorId=8 ,FirstName = "Jay", LastName = "Asher" },
                    new Author() { AuthorId=9 ,FirstName = "Gillian", LastName = "Flynn" },
                    new Author() { AuthorId=10 ,FirstName = "Dan", LastName = "Brown" }
                };


                var books = new List<Book>
                    {
                    //E-Books
                    new Book() { BookId=1 ,Title = "Einstein. Jego życie, jego wszechświat", ReleaseDate = DateTime.Parse("2014-04-02"),AuthorId=2L,PublisherId=3L ,Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook, Publisher=publishers[2], Author=authors[1]  },
                    new Book() { BookId=2 ,Title = "Steve Jobs", AuthorId = 3, PublisherId = 1, ReleaseDate = DateTime.Parse("2011-11-18"), Price = 36.44f, SuperBargain = true, Type = TypeOfBook.EBook, Publisher=publishers[0], Author=authors[2]   },
                    new Book() { BookId=3 ,Title = "Lśnienie", AuthorId = 2, PublisherId = 4, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 25.5f, SuperBargain = true, Type = TypeOfBook.EBook, Publisher=publishers[3], Author=authors[1]  },
                    new Book() { BookId=4 ,Title = "Bezsenność", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2012-03-28"), Price = 31f, Type = TypeOfBook.EBook, Publisher=publishers[1], Author=authors[1]  },
                    new Book() { BookId=5 ,Title = "Zielona mila", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2013-08-29"), Price = 28.5f, Type = TypeOfBook.EBook, Publisher=publishers[1], Author=authors[1]  },
                    new Book() { BookId=6 ,Title = "Pieśń Lodu i Ognia. Tom 2. Starcie królów", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2012-04-03"), Price = 49f, Type = TypeOfBook.EBook, Publisher=publishers[4], Author=authors[0]  },
                    new Book() { BookId=7 ,Title = "Pieśń Lodu i Ognia. Tom 3. Nawałnica mieczy. Cześć 1. Stal i śnieg", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2013-02-04"), Price = 49f, Type = TypeOfBook.EBook, Publisher=publishers[4], Author=authors[0]  },
                    new Book() { BookId=8 ,Title = "Pieśń Lodu i Ognia. Tom 3. Nawałnica mieczy. Część 2. Krew i złoto", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2014-04-07"), Price = 49f, Type = TypeOfBook.EBook, Publisher=publishers[4], Author=authors[0]  },
                    new Book() { BookId=9 ,Title = "Zaginiony symbol", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-12-22"), Price = 30f, Type = TypeOfBook.EBook, Publisher=publishers[0], Author=authors[9]  },

                    //Audiobooks
                    new Book() { BookId=10 ,Title = "Pieśń Lodu i Ognia. Tom 1. Gra o tron", AuthorId = 1, PublisherId = 5, ReleaseDate = DateTime.Parse("2015-12-17"), Price = 49.49f, Type = TypeOfBook.Audiobook, Publisher=publishers[4], Author=authors[0]  },
                    new Book() { BookId=11 ,Title = "Pan Mercedes", AuthorId = 2, PublisherId = 2, ReleaseDate = DateTime.Parse("2014-09-01"), Price = 34.49f, Type = TypeOfBook.Audiobook, Publisher=publishers[1], Author=authors[1]  },
                    new Book() { BookId=12 ,Title = "Zaginiona dziewczyna", AuthorId = 9, PublisherId = 7, ReleaseDate = DateTime.Parse("2014-10-08"), Price = 34.90f, Type = TypeOfBook.Audiobook, Publisher=publishers[6], Author=authors[8]  },
                    new Book() { BookId=13 ,Title = "Inferno", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2013-10-26"), Price = 29.99f, Type = TypeOfBook.Audiobook, Publisher=publishers[0], Author=authors[9]  },
                    new Book() { BookId=14 ,Title = "Anioły i demony", AuthorId = 10, PublisherId = 1, ReleaseDate = DateTime.Parse("2014-01-21"), Price = 31.49f, Type = TypeOfBook.Audiobook, Publisher=publishers[0], Author=authors[9]  },

                    //Previews
                    new Book() { BookId=15 ,Title = "Odrodzone Królestwo. Tom 3. Płomienna korona", AuthorId = 4, PublisherId = 5, ReleaseDate = DateTime.Now.AddDays(7), Price = 49f, Type = TypeOfBook.EBook, Publisher=publishers[4], Author=authors[3]  },
                    new Book() { BookId=16 ,Title = "Prokurator", AuthorId = 6, PublisherId = 6, ReleaseDate = DateTime.Now.AddDays(10), Price = 34.9f, Type = TypeOfBook.EBook, Publisher=publishers[5], Author=authors[5]  },
                    new Book() { BookId=17 ,Title = "Healthy mama. Poradnik zdrowej mamy", AuthorId = 7, PublisherId = 7, ReleaseDate = DateTime.Now.AddDays(11), Price = 49.9f, Type = TypeOfBook.EBook, Publisher=publishers[6], Author=authors[6]  },

                    //Novelties
                    new Book() { BookId=18 ,Title = "Odrodzone Królestwo. Tom 3. Płomienna korona", AuthorId = 5, PublisherId = 4, ReleaseDate = DateTime.Now.AddDays(-7), Price = 38f, Type = TypeOfBook.EBook, Publisher=publishers[3], Author=authors[4]  },
                    new Book() { BookId=19 ,Title = "13 powodów", AuthorId = 8, PublisherId = 1, ReleaseDate = DateTime.Now.AddDays(-2), Price = 34.49f, SuperBargain = true, Type = TypeOfBook.Audiobook, Publisher=publishers[0], Author=authors[7]  }
                    };

                return books;
            }

            public static List<Carrier> GetAllCarriers()
            {
                var carriers = new List<Carrier>
                {
                    new Carrier() {CarrierId=1, Name="PenDrive"},
                    new Carrier() { CarrierId=2 ,Name = "płyta CD" },
                    new Carrier() { CarrierId=3 ,Name = "płyta DVD" }
                };
                return carriers;
            }

        }
    }
}

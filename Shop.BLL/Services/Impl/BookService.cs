using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BLL.DTOs;
using Shop.DAL.Models;
using Shop.DAL.Repositories;
using AutoMapper;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Shop.BLL.Services.Impl
{
    class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        private Expression<Func<Book, bool>> _expressionQuery;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public IEnumerable<BookDTO> GetAllByCriteria(string query, string orderBy)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName+ " " +obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null);

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetAudiobooksByCriteria(string query, string orderBy)
        {
            _expressionQuery = obj =>
                (obj.Title.Contains(query)
                || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
                || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
                || query == null)
                && obj.Type == TypeOfBook.Audiobook;

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetEbooksByCriteria(string query, string orderBy)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && obj.Type == TypeOfBook.EBook;

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetNoveltiesByCriteria(string query, string orderBy)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.ReleaseDate > DbFunctions.AddDays(DateTime.Now, -14) && obj.ReleaseDate < DateTime.Now);

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetPreviewsByCriteria(string query, string orderBy)
        {
            
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.ReleaseDate < DbFunctions.AddDays(DateTime.Now,14) && obj.ReleaseDate > DateTime.Now);

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetSuperBargainsByCriteria(string query, string orderBy)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.SuperBargain == true);

            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy(orderBy), _expressionQuery));
        }


        //Etap V

        public IEnumerable<BookDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy("title")));
        }


        public IEnumerable<BookDTO> GetByPublisher(string publisher)
        {
            _expressionQuery = obj => obj.Publisher.Name.ToLower() == publisher.ToLower();
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy("title"), _expressionQuery));
        }

        public IEnumerable<BookDTO> GetByTitle(string title)
        {
            _expressionQuery = obj => obj.Title.Contains(title);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy("title"), _expressionQuery));
        }


        public IEnumerable<BookDTO> GetByType(string type)
        {
            if (!type.ToLower().Equals("audiobook") && !type.ToLower().Equals("e-book"))
                return new List<BookDTO>();

            _expressionQuery = obj => obj.Type == (type.ToLower() == "audiobook" ? TypeOfBook.Audiobook : TypeOfBook.EBook);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(OrderBy("title"), _expressionQuery));
        }

        private Func<IQueryable<Book>, IOrderedQueryable<Book>> OrderBy(string orderBy)
        {
            switch (orderBy)
            {
                case "releaseDate":
                    return books => books.OrderBy(book => book.ReleaseDate);
                case "releaseDate_desc":
                    return books => books.OrderByDescending(book => book.ReleaseDate);
                case "price":
                    return books => books.OrderBy(book => book.Price);
                case "price_desc":
                    return books => books.OrderByDescending(book => book.Price);
                case "author":
                    return books => books.OrderBy(book => book.Author.LastName);
                case "author_desc":
                    return books => books.OrderByDescending(book => book.Author.LastName);
                case "publisher":
                    return books => books.OrderBy(book => book.Publisher.Name);
                case "publisher_desc":
                    return books => books.OrderByDescending(book => book.Publisher.Name);
                case "title_desc":
                    return books => books.OrderByDescending(book => book.Title);
                default:
                    return books => books.OrderBy(book => book.Title);
            }
        }
    }
}

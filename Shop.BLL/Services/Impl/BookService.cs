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
        private Expression<Func<Book, object>> _expressionSort;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<BookDTO> GetAllByCriteria(string query, string sortBy, int sortType)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName+ " " +obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null);

            SetExpressionSort(sortBy);

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }

        public IEnumerable<BookDTO> GetAudiobooksByCriteria(string query, string sortBy, int sortType)
        {
            _expressionQuery = obj =>
                (obj.Title.Contains(query)
                || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
                || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
                || query == null)
                && obj.Type == TypeOfBook.Audiobook;

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }

        public IEnumerable<BookDTO> GetEbooksByCriteria(string query, string sortBy, int sortType)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && obj.Type == TypeOfBook.EBook;

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }

        public IEnumerable<BookDTO> GetNoveltiesByCriteria(string query, string sortBy, int sortType)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.ReleaseDate > DbFunctions.AddDays(DateTime.Now, -14) && obj.ReleaseDate < DateTime.Now);

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }

        public IEnumerable<BookDTO> GetPreviewsByCriteria(string query, string sortBy, int sortType)
        {
            
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.ReleaseDate < DbFunctions.AddDays(DateTime.Now,14) && obj.ReleaseDate > DateTime.Now);

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }

        public IEnumerable<BookDTO> GetSuperBargainsByCriteria(string query, string sortBy, int sortType)
        {
            _expressionQuery = obj =>
               (obj.Title.Contains(query)
               || (obj.Author.FirstName + " " + obj.Author.LastName).Contains(query)
               || (obj.Author.LastName + " " + obj.Author.FirstName).Contains(query)
               || query == null)
               && (obj.SuperBargain == true);

            SetExpressionSort(sortBy);
            return Mapper.Map<IEnumerable<BookDTO>>(_bookRepository.Find(_expressionQuery, _expressionSort, sortType));
        }


        private void SetExpressionSort(string sortBy)
        {
            switch (sortBy)
            {
                case "ReleaseDate":
                    _expressionSort = obj => obj.ReleaseDate.ToString();
                    break;
                case "Price":
                    _expressionSort = obj => obj.Price.ToString();
                    break;
                case "Author":
                    _expressionSort = obj => obj.Author.LastName;
                    break;
                case "Publisher":
                    _expressionSort = obj => obj.Publisher.Name;
                    break;
                default:
                    _expressionSort = obj => obj.Title;
                    break;
            }
        }
    }
}

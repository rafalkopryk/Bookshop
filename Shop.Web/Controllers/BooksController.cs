using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Shop.BLL.DTOs;
using Shop.BLL.Services;

namespace Shop.Web.Controllers
{
    public class BooksController : ApiController
    {
        private readonly IBookService _bookRepository;

        public BooksController(IBookService bookRepository)
        {
            _bookRepository = bookRepository;
        }

        // GET: api/books/all
        [HttpGet]
        [Route("api/books/all")]
        public IEnumerable<BookDTO> GetAllBooks([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType  = 1)
        {
            return _bookRepository.GetAllByCriteria(query, sortBy, sortType);
        }

        // GET: api/books/audiobooks
        [HttpGet]
        [Route("api/books/audiobooks")]
        public IEnumerable<BookDTO> GetAudiobooks([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType = 1)
        {
            return _bookRepository.GetAudiobooksByCriteria(query, sortBy, sortType);
        }

        // GET: api/books/ebooks
        [HttpGet]
        [Route("api/books/ebooks")]
        public IEnumerable<BookDTO> GetEbooks([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType = 1)
        {
            return _bookRepository.GetEbooksByCriteria(query, sortBy, sortType);
        }

        // GET: api/books/novelties
        [HttpGet]
        [Route("api/books/novelties")]
        public IEnumerable<BookDTO> GetNovelties([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType = 1)
        {
            return _bookRepository.GetNoveltiesByCriteria(query, sortBy, sortType);
        }

        // GET: api/books/previews
        [HttpGet]
        [Route("api/books/previews")]
        public IEnumerable<BookDTO> GetPreviews([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType = 1)
        {
            return _bookRepository.GetPreviewsByCriteria(query, sortBy, sortType);
        }

        // GET: api/books/super-bargains
        [HttpGet]
        [Route("api/books/super-bargains")]
        public IEnumerable<BookDTO> GetSuperBargains([FromUri] string query = null, [FromUri] string sortBy = null, [FromUri] int sortType = 1)
        {
            return _bookRepository.GetSuperBargainsByCriteria(query, sortBy, sortType);
        }


    }
}
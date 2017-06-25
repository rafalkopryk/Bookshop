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
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        // GET: api/books/all
        [HttpGet]
        [Route("api/books/all")]
        public IEnumerable<BookDTO> GetAllBooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetAllByCriteria(query, orderBy);
        }

        // GET: api/books/audiobooks
        [HttpGet]
        [Route("api/books/audiobooks")]
        public IEnumerable<BookDTO> GetAudiobooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetAudiobooksByCriteria(query, orderBy);
        }

        // GET: api/books/ebooks
        [HttpGet]
        [Route("api/books/ebooks")]
        public IEnumerable<BookDTO> GetEbooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetEbooksByCriteria(query, orderBy);
        }

        // GET: api/books/novelties
        [HttpGet]
        [Route("api/books/novelties")]
        public IEnumerable<BookDTO> GetNovelties([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetNoveltiesByCriteria(query, orderBy);
        }

        // GET: api/books/previews
        [HttpGet]
        [Route("api/books/previews")]
        public IEnumerable<BookDTO> GetPreviews([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetPreviewsByCriteria(query, orderBy);
        }

        // GET: api/books/super-bargains
        [HttpGet]
        [Route("api/books/super-bargains")]
        public IEnumerable<BookDTO> GetSuperBargains([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookService.GetSuperBargainsByCriteria(query, orderBy);
        }


        //W ramach Etapu V

        // GET: api/books
        [HttpGet]
        [Route("api/books")]
        public IEnumerable<BookDTO> GetAll()
        {
            return _bookService.GetAll();
        }

        // GET: api/books/title?title={title}
        [HttpGet]
        [Route("api/books/title")]
        public IEnumerable<BookDTO> GetAllByTitle([FromUri] string title)
        {
            return _bookService.GetByTitle(title);
        }

        // GET: api/publishers/{publisher}/books
        [HttpGet]
        [Route("api/publishers/{publisher}/books")]
        public IEnumerable<BookDTO> GetAllByPublisher(string publisher)
        {
            return _bookService.GetByPublisher(publisher);
        }

        // GET: api/{type}/books
        [HttpGet]
        [Route("api/{type}/books")]
        public IEnumerable<BookDTO> GetAllByType(string type)
        {
            return _bookService.GetByType(type);
        }
    }
}
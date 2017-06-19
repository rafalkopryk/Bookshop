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
        public IEnumerable<BookDTO> GetAllBooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetAllByCriteria(query, orderBy);
        }

        // GET: api/books/audiobooks
        [HttpGet]
        [Route("api/books/audiobooks")]
        public IEnumerable<BookDTO> GetAudiobooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetAudiobooksByCriteria(query, orderBy);
        }

        // GET: api/books/ebooks
        [HttpGet]
        [Route("api/books/ebooks")]
        public IEnumerable<BookDTO> GetEbooks([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetEbooksByCriteria(query, orderBy);
        }

        // GET: api/books/novelties
        [HttpGet]
        [Route("api/books/novelties")]
        public IEnumerable<BookDTO> GetNovelties([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetNoveltiesByCriteria(query, orderBy);
        }

        // GET: api/books/previews
        [HttpGet]
        [Route("api/books/previews")]
        public IEnumerable<BookDTO> GetPreviews([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetPreviewsByCriteria(query, orderBy);
        }

        // GET: api/books/super-bargains
        [HttpGet]
        [Route("api/books/super-bargains")]
        public IEnumerable<BookDTO> GetSuperBargains([FromUri] string query = null, [FromUri] string orderBy = null)
        {
            return _bookRepository.GetSuperBargainsByCriteria(query, orderBy);
        }


        //W ramach Etapu V

        // GET: api/books
        [HttpGet]
        [Route("api/books")]
        public IEnumerable<BookDTO> GetAll()
        {
            return _bookRepository.GetAll();
        }

        // GET: api/books/title?title={title}
        [HttpGet]
        [Route("api/books/title")]
        public IEnumerable<BookDTO> GetAllByTitle([FromUri] string title)
        {
            return _bookRepository.GetByTitle(title);
        }

        // GET: api/books/publisher?publisher={publisher}
        [HttpGet]
        [Route("api/publisher/{publisher}/books")]
        public IEnumerable<BookDTO> GetAllByPublisher(string publisher)
        {
            return _bookRepository.GetByPublisher(publisher);
        }

        // GET: api/books/type?type={type}
        [HttpGet]
        [Route("api/{type}/books")]
        public IEnumerable<BookDTO> GetAllByType(string type)
        {
            return _bookRepository.GetByType(type);
        }
    }
}
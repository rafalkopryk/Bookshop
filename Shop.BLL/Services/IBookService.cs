
using Shop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Services
{
    public interface IBookService
    {
        IEnumerable<BookDTO> GetAllByCriteria(string query, string orderBy);
        IEnumerable<BookDTO> GetAudiobooksByCriteria(string query, string orderBy);
        IEnumerable<BookDTO> GetEbooksByCriteria(string query, string orderBy);
        IEnumerable<BookDTO> GetNoveltiesByCriteria(string query, string orderBy);
        IEnumerable<BookDTO> GetPreviewsByCriteria(string query, string orderBy);
        IEnumerable<BookDTO> GetSuperBargainsByCriteria(string query, string orderBy);

        //Etap V
        IEnumerable<BookDTO> GetAll();
        IEnumerable<BookDTO> GetByType(string type);
        IEnumerable<BookDTO> GetByPublisher(string publisher);
        IEnumerable<BookDTO> GetByTitle(string title);
    }
}

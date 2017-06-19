
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
        IEnumerable<BookDTO> GetAllByCriteria(string query, string sortBy, int sortType);
        IEnumerable<BookDTO> GetAudiobooksByCriteria(string query, string sortBy, int sortType);
        IEnumerable<BookDTO> GetEbooksByCriteria(string query, string sortBy, int sortType);
        IEnumerable<BookDTO> GetNoveltiesByCriteria(string query, string sortBy, int sortType);
        IEnumerable<BookDTO> GetPreviewsByCriteria(string query, string sortBy, int sortType);
        IEnumerable<BookDTO> GetSuperBargainsByCriteria(string query, string sortBy, int sortType);
    }
}

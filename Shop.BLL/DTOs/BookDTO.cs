using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.DTOs
{
    public class BookDTO
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public bool SuperBargain { get; set; }
    }
}

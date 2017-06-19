using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models
{
    public class Book
    {
        public long BookId { get; set; }
        public string Title { get; set; }
        public float Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        public TypeOfBook Type { get; set; }
        [DefaultValue(false)]
        public bool SuperBargain { get; set; }
        public long PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        public long AuthorId { get; set; }
        public virtual Author Author { get; set; }   
    }
}

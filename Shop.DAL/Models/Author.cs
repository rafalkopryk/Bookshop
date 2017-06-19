using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models
{
    public class Author
    {
        public long AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author()
        {
            this.Books = new HashSet<Book>();
        }

        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }

    }
}

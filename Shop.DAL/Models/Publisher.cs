using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models
{
    public class Publisher
    {
        
        public long PublisherId { get; set; }
        public string Name { get; set; }

        public Publisher()
        {
            this.Books = new HashSet<Book>();
        }

        [JsonIgnore]
        public virtual ICollection<Book> Books { get; set; }
    }
}

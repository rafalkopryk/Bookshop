using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models
{
    public class Carrier
    {
        public long CarrierId { get; set; }
        public string Name { get; set; }
    }
}

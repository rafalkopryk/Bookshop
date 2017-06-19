using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Repositories.Impl
{
    class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}

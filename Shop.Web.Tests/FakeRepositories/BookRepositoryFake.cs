using Shop.DAL.Models;
using Shop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Web.Tests.FakeRepositories
{
    class BookRepositoryFake : RepositoryFake<Book>, IBookRepository
    {
        public BookRepositoryFake(IEnumerable<Book> items) : base(items)
        {
        }
    }
}

using Shop.DAL.Models;
using Shop.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Web.Tests.FakeRepositories
{
    class CarrierRepositoryFake : RepositoryFake<Carrier>, ICarrierRepository
    {
        public CarrierRepositoryFake(IEnumerable<Carrier> items) : base(items)
        {
        }
    }
}

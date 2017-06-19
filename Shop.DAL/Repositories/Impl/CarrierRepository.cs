using Shop.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Repositories.Impl
{
    class CarrierRepository : Repository<Carrier>, ICarrierRepository
    {
        public CarrierRepository(ShopDbContext shopDbContext) : base(shopDbContext)
        {
        }
    }
}

using Shop.BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.BLL.Services
{
    public interface ICarrierService
    {
        IEnumerable<CarrierDTO> GetAll();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.BLL.DTOs;
using Shop.DAL.Models;
using Shop.DAL.Repositories;
using AutoMapper;

namespace Shop.BLL.Services.Impl
{
    class CarrierService : ICarrierService
    {
        private readonly ICarrierRepository _carrierRepository;

        public CarrierService(ICarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }

        public IEnumerable<CarrierDTO> GetAll()
        {
            return Mapper.Map<IEnumerable<CarrierDTO>>(_carrierRepository.Find());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Shop.DAL;
using Shop.DAL.Models;
using Shop.BLL.Services;
using Shop.BLL.DTOs;

namespace Shop.Web.Controllers
{
    public class CarriersController : ApiController
    {
        
        private readonly ICarrierService _carrierService;

        public CarriersController(ICarrierService carrierService)
        {
            _carrierService = carrierService;
        }

        // GET: api/carriers
        [HttpGet]
        [Route("api/carriers")]
        public IEnumerable<CarrierDTO> GetCarriers()
        {
            return _carrierService.GetAll();    
        }
      
    }
}
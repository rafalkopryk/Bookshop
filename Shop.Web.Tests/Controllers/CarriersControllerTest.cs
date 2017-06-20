using NUnit.Framework;
using Shop.BLL;
using Shop.BLL.Services;
using Shop.BLL.Services.Impl;
using Shop.DAL.Models;
using Shop.Web.Controllers;
using Shop.Web.Tests.FakeRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Shop.Web.Tests.TestHelper;

namespace Shop.Web.Tests.Controllers
{
    [TestFixture]
    class CarriersControllerTest
    {

        public CarriersControllerTest()
        {
            MapperConfig.Register();
        }


        [Test]
        public void GetCarriers_ShouldReturnAllCarriers()
        {
            var controller = GetCarriersController();
            Assert.AreEqual(3, controller.GetCarriers().Count());
        }




        private CarriersController GetCarriersController()
        { 
            var repository = new CarrierRepositoryFake(DataInitializer.GetAllCarriers());
            var service = new CarrierService(repository);
            return new CarriersController(service);
        }
    }
}

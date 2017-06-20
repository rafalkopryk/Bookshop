using NUnit.Framework;
using Shop.BLL;
using Shop.BLL.Services.Impl;
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
    class BooksControllerTest
    {

        public BooksControllerTest()
        {
            MapperConfig.Register();
        }


        //Method GetAll

        [Test]
        public void GetAll_ShouldReturnAllBooks()
        {
            var controller = GetBooksController();
            Assert.AreEqual(19, controller.GetAll().Count());
        }

        //Method GetAllByPublisher

        [Test]
        public void GetAllByPublisher_GetBooksWithCorrectPublisher_ShouldReturnAllBooksByPublisher()
        {
            var controller = GetBooksController();
            Assert.AreEqual(5, controller.GetAllByPublisher("Insignis").Count());
            Assert.AreEqual(3, controller.GetAllByPublisher("Albatros").Count());
        }


        [Test]
        public void GetAllByPublisher_GetBooksWithCorrectPublisherUppercase_ShouldReturnAllBooksByPublisher()
        {
            var controller = GetBooksController();
            Assert.AreEqual(5, controller.GetAllByPublisher("INSIGNIS").Count());
            Assert.AreEqual(3, controller.GetAllByPublisher("ALBATROS").Count());
        }

        [Test]
        public void GetAllByPublisher_GetBooksWithCorrectPublisherLowercase_ShouldReturnAllBooksByPublisher()
        {
            var controller = GetBooksController();
            Assert.AreEqual(5, controller.GetAllByPublisher("insignis").Count());
            Assert.AreEqual(3, controller.GetAllByPublisher("albatros").Count());
        }


        [Test]
        public void GetAllByPublisher_GetBooksWithIncorrectPublisher_ShouldReturnEmptyList()
        {
            var controller = GetBooksController();
            Assert.AreEqual(0, controller.GetAllByPublisher("Test").Count());
        }

        //Method GetAllByType

        [Test]
        public void GetAllByType_GetBooksWithCorrectType_ShouldReturnAllBooksByType()
        {
            var controller = GetBooksController();
            Assert.AreEqual(13, controller.GetAllByType("E-Book").Count());
            Assert.AreEqual(6, controller.GetAllByType("Audiobook").Count());
        }

        [Test]
        public void GetAllByType_GetBooksWithCorrectTypeUppercase_ShouldReturnAllBooksByType()
        {
            var controller = GetBooksController();
            Assert.AreEqual(13, controller.GetAllByType("E-BOOK").Count());
            Assert.AreEqual(6, controller.GetAllByType("AUDIOBOOK").Count());
        }

        [Test]
        public void GetAllByType_GetBooksWithCorrectTypeLowercase_ShouldReturnAllBooksByType()
        {
            var controller = GetBooksController();
            Assert.AreEqual(13, controller.GetAllByType("e-Book").Count());
            Assert.AreEqual(6, controller.GetAllByType("audiobook").Count());
        }

        [Test]
        public void GetAllByPublisher_GetBooksWithIncorrectType_ShouldReturnEmptyList()
        {
            var controller = GetBooksController();
            Assert.AreEqual(0, controller.GetAllByType("Ebook").Count());
        }

        //Method GetAllByTitle
        [Test]
        public void GetAllByTitle_GetBooksWithCorrectTitleShouldReturnAllBooksByTitle()
        {
            var controller = GetBooksController();
            Assert.AreEqual(1, controller.GetAllByTitle("Anioły").Count());
            Assert.AreEqual(4, controller.GetAllByTitle("Pieśń Lodu i Ognia").Count());
        }

        [Test]
        public void GetAllByTitle_GetBooksWithCorrectTitleLowercase_ShouldReturnAllBooksByTitle()
        {
            var controller = GetBooksController();
            Assert.AreEqual(1, controller.GetAllByTitle("anioły").Count());
            Assert.AreEqual(4, controller.GetAllByTitle("pieśń lodu i ognia").Count());
        }

        [Test]
        public void GetAllByTitle_GetBooksWithCorrectTitleUppercase_ShouldReturnAllBooksByTitle()
        {
            var controller = GetBooksController();
            Assert.AreEqual(1, controller.GetAllByTitle("ANIOŁY").Count());
            Assert.AreEqual(4, controller.GetAllByTitle("PIEŚŃ LODU I OGNIA").Count());
        }

        [Test]
        public void GetAllByTitle_GetBooksWithIncorrectTitle_ShouldReturnEmptyList()
        {
            var controller = GetBooksController();
            Assert.AreEqual(0, controller.GetAllByTitle("Pinokio").Count());
        }




        private BooksController GetBooksController()
        {
            var repository = new BookRepositoryFake(DataInitializer.GetAllBooks());
            var service = new BookService(repository);
            return new BooksController(service);
        }
    }
}

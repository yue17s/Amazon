using Amazon.Controllers;
using Amazon.Models;
using System.Collections.Generic;
using Xunit;
using Amazon.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;
using Amazon.UnitTests;
using Moq;
namespace Amazon.Test
{
    public class IndexControllerTests
    {
       /* class ModelCompleteFakeRepository : IBookRepository
        {
            public IEnumerable<Book> Books { set; get; }
            /*public IEnumerable<Book> Books => new List<Book> {
                new Book() { Title = "Book1", Price = 200, NroPages = 250 },
                new Book() { Title = "Book2", Price = 300, NroPages = 180 },
                new Book() { Title = "Book3", Price = 150, NroPages = 350 },
                new Book() { Title = "Book4", Price = 300, NroPages = 400 } };
            public void AddBook(Book p)
            {
                //no requerido para el test 
            }
        }*/
        /*[Theory]
        [ClassData(typeof(BookTestData))]
        public void IndexActionModelIsComplete(IEnumerable<Book> books)
        { 
            // Arrange 
            var mock = new Mock<IRepository>();
            mock.SetupGet(m => m.Books).Returns(books);
            var controller = new HomeController
            { repository = mock.Object };
            // Act 
            var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
            // Assert 
            Assert.Equal(controller.repository.Books, model, Comparer.Get<Book>((p1, p2) => p1.Title == p2.Title && p1.NroPages == p2.NroPages));
        }*/

        class ModelCompleteFakeRepositoryPagesGreaterThan300 
        {
            public IEnumerable<Book> Books => new List<Book> {
                new Book() { Title = "Book1", Price = 200, NroPages = 320 },
                new Book() { Title = "Book2", Price = 280, NroPages = 310 },
                new Book() { Title = "Book3", Price = 150, NroPages = 500 },
                new Book() { Title = "Book4", Price = 300, NroPages = 800 } };
            public void AddBook(Book p)
            { }
        }
        [Fact]
        public void IndexActionModelIsCompletePagesGreaterThan300()
        {
            // Arrange 
            /*  var controller = new HomeController();
              controller.repository = new ModelCompleteFakeRepositoryPagesGreaterThan300();
              // Act 
              var model = (controller.Index() as ViewResult)?.ViewData.Model as IEnumerable<Book>;
              // Assert 
              Assert.Equal((controller.repository.Books as List<Book>).Count, (model as List<Book>).Count); }
         */
        }
    }
}
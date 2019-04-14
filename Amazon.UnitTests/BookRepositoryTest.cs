using Amazon.Models;
using System;
using System.Linq;
using Xunit;

namespace Amazon.UnitTests
{
    public class BookRepositoryTest
    {
        [Fact]
        public void NewBook_ShouldBeAdded()
        {
            //Arrange
            Book newBook = new Book()
            {
                Title = "Title 1",
                Author = "Author1",
                ISBN = "ISBN1",
                NroPages = 200,
                Price = 100
            };
            //Act
            BookRepository.AddResponse(newBook);
            //Assert
            Assert.Equal("Title 1", BookRepository.Books.FirstOrDefault().Title);
        }
    }
}
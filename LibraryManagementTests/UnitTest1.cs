using LibraryManagementSystem.Models;
using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Interfaces;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementTests;

public class LibraryTests
{
    private Mock<IBookService> mockBookService;
    private BookController bookController;

    [SetUp]
    public void Setup()
    {
        mockBookService = new Mock<IBookService>();
        bookController = new BookController();
    }

    [Test]
    //test to check if book was created
    public void AddBook_ShouldAddBook()
    {
        //Arrange
        var book = new Book
        {
            Title = "To Kill a Mockingbird",
            Author = "Harper Lee",
            Year = 1950
        };

        //Act
        var result = bookController.AddBook;

        //Assert
        mockBookService.Verify(service => service.AddBook(It.Is<Book>(b => b == book)), Times.Once);
        Assert.IsInstanceOf<OkObjectResult>(result);
    }
}

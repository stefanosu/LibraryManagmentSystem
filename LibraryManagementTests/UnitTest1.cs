using LibraryManagementSystem.Models;
using LibraryManagementSystem.Controllers;

namespace LibraryManagementTests;

public class LibraryTests
{
    private mockBookController
    private BookController bookController;

    [SetUp]
    public void Setup()
    {
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
        var result = bookController.AddBook(book); 

        //Assert
        Assert.AreEqual(1, books);
        Assert.AreEqual("To Kill a Mockingbird", books[0].Title);
        Assert.AreEqual("Harper Lee", books[0].Author);
        Assert.AreEqual(1950, books[0].Year);
    }
}

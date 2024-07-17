using LibraryManagementSystem.Controllers;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers;

public class Program
{
    public static void Main()
    {
        //instantiating a new instance of BookController here
        BookController bookController = new BookController();

        //Adding a new book
        bookController.AddBook(new Book { Id = 1, Title = "I know why the cage bird sings", Author = "Maya Angelou", Price = 20.00m, Year = 1975 });

        //get all books
        var allBooks = bookController.GetAllBooks();
        foreach (var book in allBooks)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price}, Year: {book.Year}");
        }

        //update book
        bookController.UpdateBook(2, new Book { Id = 2, Title = "Ishamel", Author = "Daniel Quinn", Price = 25m, Year = 1995 });

        //remove book
        bookController.RemoveBook(3);

        //get allBooks after update and remove
        allBooks = bookController.GetAllBooks();
        foreach (var book in allBooks)
        {
            Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price}, Year: {book.Year}");
        }

        //instantiating a new instance of MemberController here

        MembersController membersController = new MembersController();

        //Adding a new member
        membersController.AddMember(new Member { memberId = 1, bookId = 1, name = "Stefanos", transactionId = 1 });

        //get all members
        var allMembers = membersController.GetAllMembers();
        foreach(var member in allMembers)
        {
            Console.WriteLine($"Id:, ");
        }

        //update member 
        membersController.UpdateMember(2, new Member { memberId = 2, bookId = 3, name = "Stefanos"});

        //remove a member pass in memberId 
        membersController.removeMember(3);
    }
}
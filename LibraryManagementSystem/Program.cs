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
            Console.WriteLine($"Id: {member.memberId}, bookId: {member.bookId}, Name: {member.name}, transactionId: {member.transactionId}");
        }

        //update member 
        membersController.UpdateMember(2, new Member { memberId = 2, bookId = 3, name = "Stefanos"});

        //remove a member pass in memberId 
        membersController.removeMember(3);

        //  instantiating a new instance of TransactionController here
        TransactionController transactionController = new TransactionController();

        // Adding a new transaction
        transactionController.addTransaction(new Transaction { transactionId = 5, bookId = 5, memberId = 4 });

        // get all transactions
        var allTransactions = transactionController.getAllTransactions();
        foreach(var transaction in allTransactions)
        {
            Console.WriteLine($"TransactionId: {transaction.transactionId}, BookId: {transaction.bookId}, MemberId: {transaction.memberId}");
        }

        //update transactions
        transactionController.updateTransaction(6, new Transaction {bookId = 5, memberId = 4,  });

        //remove transaction
        transactionController.removeTransaction(7);
    }
}
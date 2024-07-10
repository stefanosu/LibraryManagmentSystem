using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BookController
    {
        //create methods here for CRUD operations on books

        //creating a new instance of a Book to then add.
        BookController bookController = new BookController();

        //adding new book obj with parameters of the book



        public void AddBook(Book book)
        {
            //this method will add a Book to the list of Books.


            BookController bookController = new BookController();

            // Add a book
            bookController.AddBook(new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Year = 1925 });

        }

        private List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m },
        new Book { Id = 2, Title = "1984", Author = "George Orwell", Price = 8.99m },
        new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 9.99m }
    };


        public void GetAllBooks(Book book)
        {
            //This method will Get a list of books
            // Get all books
             IEnumerable<Book> GetAllBooks()
            {
                return books;
            }

        }

        public void UpdateBook(Book book)
        {
            //this method will update a book
        }


        public void RemoveBook(Book book)
        {
            //this method will remove a book from the list of books.
        }


        public class Program
        {
            public static void Main()
            {
                var bookController = new BookController();
                var books = bookController.GetAllBooks();

                foreach (var book in books)
                {
                    Console.WriteLine($"Id: {book}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
                }
            }


        }

        private IEnumerable<object> GetAllBooks()
        {
            throw new NotImplementedException();
        }
    }
}


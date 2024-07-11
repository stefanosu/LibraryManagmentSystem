using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
    public class BookController
    {
        //create methods here for CRUD operations on books

        /// <summary>
        /// Creating a private list of books to stimulate a data store
        /// </summary>
        private List<Book> books = new List<Book>
    {
        new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", Price = 10.99m },
        new Book { Id = 2, Title = "1984", Author = "George Orwell", Price = 8.99m },
        new Book { Id = 3, Title = "To Kill a Mockingbird", Author = "Harper Lee", Price = 9.99m }
    };

        public void AddBook(Book book)
        {
            books.Add(book); 
        }


        public List<Book> GetAllBooks()
        {
            return books;
        }

        //update a book
        public void UpdateBook(int id, Book updatedBook)
        {
            var book = books.Find(book => book.Id == id);
            if(book != null)
            {
                book.Title = updatedBook.Title;
                book.Author = updatedBook.Author;
                book.Price = updatedBook.Price;
                book.Year = updatedBook.Year;
            }
        }


        public void RemoveBook(Book book)
        {
            //this method will remove a book from the list of books.
        }


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
                foreach(var book in allBooks)
                {
                    Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Price: {book.Price}, Year: {book.Year}");
                }

                //update book
                bookController.UpdateBook(2, new Book { Id = 2, Title = "Ishamel" ,Author = "Daniel Quinn", Price = 25m , Year = 1995 });
            }
        }
    }
}


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

        //remove a book
        public void RemoveBook(int id)
        {
            var book = books.Find(book => book.Id == id);
            if(book != null)
            {
                books.Remove(book);
            }
        }
    }
}


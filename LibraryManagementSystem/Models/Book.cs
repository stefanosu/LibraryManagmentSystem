using System;
namespace LibraryManagementSystem.Models
{
    public class Book
    {
  
        //fields for book info
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; internal set; }
    }

}



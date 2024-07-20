using System;
namespace LibraryManagementSystem.Models
{
    public class Book
    {
  
        //fields for book info
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; internal set; }
    }

}



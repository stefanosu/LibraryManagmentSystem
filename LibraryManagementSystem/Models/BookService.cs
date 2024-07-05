using System;
namespace LibraryManagementSystem.Models
{
	public class BookService
	{
		public BookService()
		{

        //fields for book info
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public int Year { get; set; }
    }
	}
}


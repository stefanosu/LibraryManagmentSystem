using System;
namespace LibraryManagementSystem.Models
{
	public class MemberService
	{
		//fields for members
		public int memberId { get; set; }
		public string? name { get; set; }
		public int transactionId { get; set; }
		public int bookId { get; set; }
	}
}


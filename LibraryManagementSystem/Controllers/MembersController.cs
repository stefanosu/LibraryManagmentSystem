using System;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem.Controllers
{
	public class MembersController
	{
        //create methods here for CRUD operations for memebers


        /// <summary>
        /// Creating a private list of books to stimulate a data store
        /// </summary>
        ///
        private List<MemberService> members = new List<MemberService>
        {
            new MemberService {memberId = 1, bookId = 1, name = "Stefanos", transactionId = 1},
            new MemberService { memberId = 2, bookId = 2, name= "Mus", transactionId = 2},
            new MemberService { memberId = 3, bookId = 3, name= "Stasia", transactionId = 3}
        }; 

        public void AddMember(MemberService member)
		{
            members.Add(member);
		}
	}
}


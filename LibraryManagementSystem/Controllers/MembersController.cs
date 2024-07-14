using System;
using LibraryManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementSystem.Controllers
{
	public class MembersController : Controller 
	{
        //create methods here for CRUD operations for memebers

        /// <summary>
        /// Creating a private list of books to stimulate a data store
        /// </summary>
        ///
        private List<Member> members = new List<Member>
        {
            new Member {memberId = 1, bookId = 1, name = "Stefanos", transactionId = 1},
            new Member { memberId = 2, bookId = 2, name= "Mus", transactionId = 2},
            new Member { memberId = 3, bookId = 3, name= "Stasia", transactionId = 3},
            new Member { memberId = 3, bookId = 3, name= "Semir", transactionId = 3}
        }; 

        public void AddMember(Member member)
		{
            members.Add(member);
		}

        public List<Member> GetAllMembers()
        {
            return members;
        }

        public void UpdateMember(int memberId, Member updatedMember)
        {
            var member = members.Find(member => memberId == member.memberId);
            if(member != null)
             {
                memberId = updatedMember.memberId;
                member.name = updatedMember.name;
             }
        }

        public void removeMethod(int memberId)
        {

        }
	}
}


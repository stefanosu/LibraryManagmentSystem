    using LibraryManagementSystem.Models;
    using Microsoft.AspNetCore.Mvc;

    namespace LibraryManagementSystem.Controllers
    {
        public class TransactionController : Controller
        {
            //create methods here for CRUD operations for transactions

            //using list to stimulate a data store
            private List<Transaction> transactions = new List<Transaction>
            {
                new Transaction { transactionId = 1, bookId = 1, memberId = 1 },
                new Transaction { transactionId = 2, bookId = 2, memberId = 2 },
                new Transaction { transactionId = 3, bookId = 3, memberId = 3 },
                new Transaction { transactionId = 4, bookId = 4 ,memberId = 3 }
            };

            //add a transaction 
            public void addTransaction(Transaction transaction)
            {
                transactions.Add(transaction);
            }

            public List<Transaction> getAllTransactions()
            {
                return transactions;
            }

            public void updateTransaction(int transactionId, Transaction updateTransaction)
            {
                var transaction = transactions.Find(transaction => transactionId == transaction.transactionId);
                if (transaction != null)
                {
                    transaction.memberId = updateTransaction.memberId;
                }
            }
            //remove a transaction
            public void removeTransaction(int transactionId)
            {
                var transaction = transactions.Find(transaction => transactionId == transaction.transactionId);
                if(transaction != null)
                {
                    removeTransaction(transactionId); 
                }
            }
        }
    }


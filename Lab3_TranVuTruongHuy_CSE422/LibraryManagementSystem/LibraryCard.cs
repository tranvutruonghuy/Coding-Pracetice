using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryCard
    {
        public string CardNumber { get; }
        public Member Owner { get; set; }
        public DateTime IssueDate { get; private set; }

        public LibraryCard(string cardNumber, Member owner, DateTime issueDate)
        {
            CardNumber = cardNumber;
            Owner = owner;
            IssueDate = issueDate;
        }

        public void RenewCard()
        {
            IssueDate = DateTime.Now;
            Console.WriteLine("Library card renewed. New issue date: " + IssueDate);
        }
    }
}

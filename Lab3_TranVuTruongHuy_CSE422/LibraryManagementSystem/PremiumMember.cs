using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class PremiumMember : Member
    {
        public DateTime MembershipExpiry {  get; set; }
        public int MaxBooksAllowed { get; set; }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Membership Expiry: " + MembershipExpiry);
            Console.WriteLine("Max Books Allowed: " + MaxBooksAllowed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class AdminManager : IPrintable
    {
        public List<Admin> Admins { get; set; }

        public AdminManager(List<Admin> admins)
        {
            Admins = admins;
        }
        public void PrintDetails()
        {
            Console.WriteLine("Admin List: ");
            foreach (Admin admin in this.Admins)
            {
                admin.PrintDetails();
            }
        }
    }
}

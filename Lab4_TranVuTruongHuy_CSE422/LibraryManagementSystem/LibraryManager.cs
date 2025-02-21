using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LibraryManager : IPrintable
    {
        public AdminManager AdminManager { get; set; }
        public ReaderManager ReaderManager { get; set; }
        public PublicationManager PublicationManagement { get; set; }
        public LibraryManager(SampleGenerator sampleData)
        { 
            AdminManager = new AdminManager(sampleData.Admins);
            ReaderManager = new ReaderManager(sampleData.Readers);
            PublicationManagement = new PublicationManager(sampleData.Publications);
        }
        public bool isPublicationNull (Publication publication, string title)
        {
            if(publication == null)
            {
                Console.WriteLine($"{title} do not exist\n");
                return true;
            }
            return false;
        }
        public void PrintDetails()
        {
            AdminManager.PrintDetails();
            ReaderManager.PrintDetails();
            PublicationManagement.PrintDetails();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public abstract class ReportGenerator
    {
        public Reader Reader { get; set; }
        public Publication Publication { get; set; }
        public ReportGenerator(Reader reader, Publication publication) 
        {
            Reader = reader;
            Publication = publication;
        }

        public virtual void PrintDetails()
        {
            Console.WriteLine("----Infor before update----");
            Reader.PrintDetails();
            Publication.PrintDetails();
            Console.WriteLine("----Infor after update----");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class ReturnReportGenerator : ReportGenerator
    {
        public ReturnReportGenerator(Reader reader, Publication publication) : base(reader, publication)
        {
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Return report of {Reader.Name} for {Publication.Title} generated at: {DateTime.Now}");
            base.PrintDetails();
            Reader.UpdateBorrowingBookAfterReturn();
            Publication.UpdateQuantityAfterReturned();
            Console.WriteLine($"Borrowing book number of {Reader.Name}: {Reader.BorrowingBookNum}");
            Console.WriteLine($"Copyright number of {Publication.Title} in stock: {Publication.Quantity}");
            Console.WriteLine();
        }
    }
}

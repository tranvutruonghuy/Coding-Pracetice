using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class LendReportGenerator : ReportGenerator
    {
        public LendReportGenerator(Reader reader, Publication publication) : base(reader, publication)
        {
        }

        public override void PrintDetails()
        {

            Console.WriteLine($"Lend report of {Reader.Name} for {Publication.Title} generated at: {DateTime.Now}");
            base.PrintDetails();
            Reader.UpdateBorrowingBookAfterLend();
            Publication.UpdateQuantityAfterLended();
            Console.WriteLine($"Borrowing book number of {Reader.Name}: {Reader.BorrowingBookNum}");
            Console.WriteLine($"Copyright number of {Publication.Title} in stock: {Publication.Quantity}");
            Console.WriteLine();
        }
    }
}

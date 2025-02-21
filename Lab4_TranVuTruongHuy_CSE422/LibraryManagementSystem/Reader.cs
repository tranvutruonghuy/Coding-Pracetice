using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Reader : IPrintable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BorrowingBookNum {  get; set; }

        public Reader(int id, string name, int borrowingBook)
        {
            Id = id;
            Name = name;
            BorrowingBookNum = borrowingBook;
        }

        public void SearchPublicationByTitle(LibraryManager library, InputReaderTool inputReader)
        {
            
            string title = inputReader.GetInputInConsole("Enter title to search", "check");
            Publication publication = library.PublicationManagement.SearchPublcationByTitle(title);
            if(publication != null)
            {
                publication.PrintDetails();
            }
            else
            {
                Console.WriteLine($"There is no publications with title of {title}\n");
            
            }
        }
        public void SearchPublicationByCategory(LibraryManager library, InputReaderTool inputReader)
        {
            
            string category = inputReader.GetInputInConsole("Enter category to search", "check");
            PublicationManager publications = new PublicationManager(library.PublicationManagement.SearchPublicationByCategory(category));
            if (publications.Publications.Count > 0)
            {
                publications.PrintDetails();
            }
            else
            {
                Console.WriteLine($"There is no publications with category of {category}\n");
            }
        }
        public void LendPublication(LibraryManager library, InputReaderTool inputReader)
        {
            
            string title = inputReader.GetInputInConsole("Enter title to borrow", "check");
            Publication publication = library.PublicationManagement.SearchPublcationByTitle(title);
            if (!library.isPublicationNull(publication, title))
            {
                if (this.BorrowingBookNum < 3 && publication.Quantity > 0)
                {
                    ReportGenerator lendReport = new LendReportGenerator(this, publication);
                    lendReport.PrintDetails();
                }
                else
                {
                    Console.WriteLine("Borrowing conditions are not enough!");
                }
            }
        }
        public void ReturnPublication(LibraryManager library, InputReaderTool inputReader)
        {
            string title = inputReader.GetInputInConsole("Enter title to return", "check");
            Publication publication = library.PublicationManagement.SearchPublcationByTitle(title);
            if (!library.isPublicationNull(publication, title))
            {
                ReportGenerator returnReport = new ReturnReportGenerator(this, publication);
                returnReport.PrintDetails();
            }
        }
        public void UpdateBorrowingBookAfterReturn()
        {
            this.BorrowingBookNum--;
        }
        public void UpdateBorrowingBookAfterLend()
        {
            this.BorrowingBookNum++;
        }
        public void PrintDetails()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Number of borrowing books: {BorrowingBookNum}");
            Console.WriteLine();
        }
    }
}

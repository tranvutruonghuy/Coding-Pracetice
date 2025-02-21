namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InputReaderTool inputReaderTool = new InputReaderTool();
            SampleGenerator sample = new SampleGenerator();
            LibraryManager library = new LibraryManager(sample);
            //Show library infomation:
            Console.WriteLine("Library details:");
            library.PrintDetails();

            //Get admin: 
            Admin admin = library.AdminManager.Admins.FirstOrDefault();
            //Print admin
            Console.WriteLine("Show current admin details:");
            admin.PrintDetails();


            //Admin add book function:
            Console.WriteLine("Demo adding book function: ");
            admin.AddNewBook(library, inputReaderTool);
            Console.WriteLine("Library details after adding new book:");
            library.PrintDetails();


            //Get reader:
            Reader reader = library.ReaderManager.Readers.FirstOrDefault();
            //Print reader
            Console.WriteLine("Show current reader details:");
            reader.PrintDetails();

            //Reader search book by title function:
            Console.WriteLine("Demo reader seaching book by title: ");
            reader.SearchPublicationByTitle(library, inputReaderTool);

            //Reader search book by category function:
            Console.WriteLine("Demo reader seaching book by category: ");
            reader.SearchPublicationByCategory(library, inputReaderTool);


            //Reader borrow book:
            reader.LendPublication(library, inputReaderTool);
            reader.LendPublication(library, inputReaderTool);
            reader.LendPublication(library, inputReaderTool);
            reader.ReturnPublication(library, inputReaderTool);
            reader.LendPublication(library, inputReaderTool);

            //Reader return book:
            reader.ReturnPublication(library, inputReaderTool);
            reader.ReturnPublication(library, inputReaderTool);
        }
    }
}

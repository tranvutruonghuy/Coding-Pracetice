namespace LibraryManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4
            Console.WriteLine("Exercise 4");
            Member member = new Member { MemberID = "1", Name = "Nguyen Van A", Email= "a@gmail.com" };
            Book book1 = new Book { ISBN = "123456789", Title = "Doraemon", Author = "Author 1", CopiesAvailable = 1 };
            List<Transaction> transactionList = new List<Transaction>()
            {
                new BorrowTransaction 
                { 
                    BookBorrowed = book1, 
                    Member = member, 
                    TransactionDate = DateTime.Now, 
                    TransactionID = "1" 
                },
                new BorrowTransaction
                {
                    BookBorrowed = book1,
                    Member = member,
                    TransactionDate = DateTime.Now,
                    TransactionID = "2"
                },
                new ReturnTransaction
                {
                    BookReturned = book1,
                    Member = member,
                    TransactionDate = DateTime.Now,
                    TransactionID = "3"
                },
                new BorrowTransaction
                {
                    BookBorrowed = book1,
                    Member = member,
                    TransactionDate = DateTime.Now,
                    TransactionID = "4"
                },
            };
            foreach (Transaction transaction in transactionList)
            {
                transaction.Execute();
            }

            Console.WriteLine();

            //Exercise 7
            Console.WriteLine("Exercise 7");
            // Create an object of NotificationService
            NotificationService notificationService = new NotificationService();
            notificationService.SendNotification("Hello, world!");
            notificationService.SendNotification("Hello", "John");
            notificationService.SendNotification("Hello", new List<string> { "Alice", "Bob", "Charlie" });

            Console.WriteLine();

            // Create an object of AdvancedNotificationService
            AdvancedNotificationService advancedNotificationService = new AdvancedNotificationService();
            advancedNotificationService.SendNotification("Hello, advanced world!");
        
        
            Console.WriteLine();
            //Exercise 9
            Console.WriteLine("Exercise 9");
            BookClass bookClass1 = new BookClass { ISBN = "123", Title = "Doraemon", Author = "Jon Skeet" };
            BookClass bookClass2 = new BookClass { ISBN = "123", Title = "Doraemon", Author = "Jon Skeet" };
            
            bool areClassBooksEqual = bookClass1 == bookClass2;
            Console.WriteLine($"BookClass comparison using '==': {areClassBooksEqual}");

            Console.WriteLine();

            BookRecord bookRecord1 = new BookRecord("123", "Doraemon", "Jon Skeet");
            BookRecord bookRecord2 = new BookRecord("123", "Doraemon", "Jon Skeet");

            bool areRecordBooksEqual = bookRecord1 == bookRecord2;
            Console.WriteLine($"BookRecord comparison using '==': {areRecordBooksEqual}");

            BookRecord bookRecord3 = bookRecord1 with { Title = "Pokemon" };
            Console.WriteLine($"Original BookRecord: {bookRecord1.Title}");
            Console.WriteLine($"Modified BookRecord: {bookRecord3.Title}");

            Console.WriteLine();
            Console.WriteLine("Explain the differences between class and record based on the experimental results: \n");
            Console.WriteLine("1. Comparison using == Operator:\n");
            Console.WriteLine("Class (BookClass): Classes are reference types, meaning they compare by reference. When we compare two instances of BookClass using the == operator, it checks whether both references point to the same object in memory. Hence, bookClass1 == bookClass2 is false because they are different objects, even though their property values are the same. \n");
            Console.WriteLine("Record (BookRecord): Records are also reference types, but they compare by value. This means that when we compare two instances of BookRecord using the == operator, it checks whether their property values are the same. Hence, bookRecord1 == bookRecord2 is true because their property values are identical \n");
            Console.WriteLine("2. Using with to Create a Copy\n");
            Console.WriteLine("Class (BookClass): Classes do not support the with expression natively. To create a copy with modified properties, we would need to manually create a new instance and set the desired properties.\n");
            Console.WriteLine("Record (BookRecord): Records support the with expression, allowing us to create a new copy of an existing record with modified properties easily. In the example, bookRecord3 is a copy of bookRecord1 with the Title property modified.\n");


            //Exercise 10
            Console.WriteLine("Exercise 10");
            
            Member member10 = new Member { MemberID = "M001", Name = "John Doe", Email = "john.doe@example.com" };

            // Create books
            Book book10 = new Book { ISBN = "123456789", Title = "Doraemon", Author = "Author 1", Year = 2020, CopiesAvailable = 3 };

            // Create a library and add the book
            Library library = new Library();
            library.Books.Add(book10);
            library.Members.Add(member10);

            // Create notification services
            NotificationService notificationService1 = new NotificationService();
            NotificationService notificationService2 = new NotificationService();
            NotificationService notificationService3 = new NotificationService();
            // Subscribe to the OnBookBorrowed event
            notificationService1.Subscribe(library);
            notificationService2.Subscribe(library);
            notificationService3.Subscribe(library);
            // Borrow a book to trigger the event
            library.BorrowBook(book10, member10);
        }
    }
}

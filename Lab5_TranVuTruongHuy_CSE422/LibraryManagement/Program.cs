namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get database connection (Singleton)
            var database = DatabaseConnection.Instance;

            // Create factories
            DocumentFactory bookFactory = new BookFactory();
            DocumentFactory magazineFactory = new MagazineFactory();

            // Create library with fee strategy
            Library library = new Library(new OverdueFeeStrategy());

            // Register users
            User user1 = new User("U1", "John");
            User user2 = new User("U2", "Jane");
            library.RegisterObserver(user1);
            library.RegisterObserver(user2);

            // Add documents
            IDocument book = bookFactory.CreateDocument("B1", "Design Patterns");
            IDocument magazine = magazineFactory.CreateDocument("M1", "Tech Weekly");
            library.AddDocument(book);
            library.AddDocument(magazine);

            // Test borrowing and returning
            library.BorrowDocument("B1", user1);
            double fee = library.ReturnDocument("B1", 20);
            Console.WriteLine($"Fee charged: ${fee}");
        }
    }
}

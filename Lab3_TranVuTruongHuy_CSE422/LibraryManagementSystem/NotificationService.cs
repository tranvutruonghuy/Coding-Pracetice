using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class NotificationService
    {
        public virtual void SendNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
        public void SendNotification(string message, string recipient)
        {
            Console.WriteLine($"Notification to {recipient}: {message}");
        }
        public void SendNotification(string message, List<string> recipients)
        {
            foreach (var recipient in recipients)
            {
                Console.WriteLine($"Notification to {recipient}: {message}");
            }
        }
        public void OnBookBorrowed(Book book, Member member)
        {
            Console.WriteLine($"Notification: {member.Name} borrowed {book.Title}.");
        }
        public void Subscribe(Library library)
        {
            library.OnBookBorrowed += OnBookBorrowed;

        }
    }
}

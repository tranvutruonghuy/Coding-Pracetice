using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class User : ILibraryObserver
    {
        public string Id { get; }
        public string Name { get; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"Notification for {Name}: {message}");
        }
    }
}

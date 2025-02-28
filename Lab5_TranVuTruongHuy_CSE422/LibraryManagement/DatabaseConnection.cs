using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Singleton Pattern for Database Connection
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private DatabaseConnection()
        {
            Console.WriteLine("Database connection established");
        }

        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DatabaseConnection();
                }
                return instance;
            }
        }
    }
}

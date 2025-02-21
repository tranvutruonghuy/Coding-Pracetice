using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class SampleGenerator
    {
        public List<Admin> Admins { get; set; }
        public List<Publication> Publications { get; set; }
        public List<Reader> Readers { get; set; }

        public SampleGenerator()
        {
            Admins = new List<Admin>();
            Publications = new List<Publication>();
            Readers = new List<Reader>();

            Admin admin1 = new Admin(1, "HuyAmin");
            Admin admin2 = new Admin(2, "CuongAmin");
            Admins.Add(admin1);
            Admins.Add(admin2);

            Publication book1 = new Book(1, "The way of success", "David", "Business", 2);
            Publication book2 = new Book(2, "How to become the best chief", "Peter", "Business", 5);
            Publications.Add(book1);
            Publications.Add(book2);

            Reader reader1 = new Reader(1, "Nguyen Van A", 0);
            Reader reader2 = new Reader(2, "Nguyen Van B", 0);
            Readers.Add(reader1);
            Readers.Add(reader2);


        }
    }
}

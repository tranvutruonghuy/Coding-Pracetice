using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class ReaderManager : IPrintable
    {
        public List<Reader> Readers { get; set; }

        public ReaderManager(List<Reader> readers)
        {
            Readers = readers;
        }

        public void PrintDetails()
        {
            Console.WriteLine("Reader List: ");
            foreach (Reader reader in this.Readers)
            {
                reader.PrintDetails();
            }
        }
    }
}

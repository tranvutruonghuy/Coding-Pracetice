using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class BookFactory : DocumentFactory
    {
        public override IDocument CreateDocument(string id, string title)
        {
            return new Book(id, title);
        }
    }
}

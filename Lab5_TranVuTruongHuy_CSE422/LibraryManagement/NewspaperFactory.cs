using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class NewspaperFactory : DocumentFactory
    {
        public override IDocument CreateDocument(string id, string title)
        {
            return new Newspaper(id, title);
        }
    }
}

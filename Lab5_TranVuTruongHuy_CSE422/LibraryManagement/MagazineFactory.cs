using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class MagazineFactory : DocumentFactory
    {
        public override IDocument CreateDocument(string id, string title)
        {
            return new Magazine(id, title);
        }
    }
}

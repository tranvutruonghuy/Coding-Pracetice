using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Factory Method Pattern for Document Creation
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument(string id, string title);
    }
}

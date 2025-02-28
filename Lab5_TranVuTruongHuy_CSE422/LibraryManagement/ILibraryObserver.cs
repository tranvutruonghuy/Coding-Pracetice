using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    // Observer Pattern for Notifications
    public interface ILibraryObserver
    {
        void Update(string message);
    }
}

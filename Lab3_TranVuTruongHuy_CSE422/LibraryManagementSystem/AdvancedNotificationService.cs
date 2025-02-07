using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class AdvancedNotificationService : NotificationService
    {
        public override void SendNotification(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine($"[{timestamp}] Notification: {message}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.D
{
    internal class Wrong
    {
        public class EmailNotification
        {
            public void Send(string message)
            {
                // send email
            }
        }

        public class DatabaseManager
        {
            private EmailNotification notification;

            public DatabaseManager()
            {
                notification = new EmailNotification();
            }

            public void Add()
            {
                notification.Send("Record added to database!");
            }

            public void Remove()
            {
                notification.Send("Record removed to database!");
            }

            public void Persisit()
            {
                notification.Send("Changes submitted to database!");
            }
        }
    }
}

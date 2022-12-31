using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.O.L.I.D.D
{
    internal class Soulation
    {
        public interface INotification
        {
            void Send(string message);
        }

        public class EmailNotification : INotification
        {
            public void Send(string message)
            {
                // send email
            }
        }

        public class SMSNotification : INotification
        {
            public void Send(string message)
            {
                // send sms
            }
        }

        public class DatabaseManager
        {
            private INotification notification;

            public DatabaseManager(INotification notification)
            {
                this.notification = notification;
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

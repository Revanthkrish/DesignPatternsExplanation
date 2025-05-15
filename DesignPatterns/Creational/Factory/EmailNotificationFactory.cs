using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    public class EmailNotificationFactory:NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}

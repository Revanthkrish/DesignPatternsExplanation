using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    // Abstract factory class which defines a method to create notifications
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification(); // Factory method
    }
}

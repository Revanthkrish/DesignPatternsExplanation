using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    // Common interface for all notification types
    public interface INotification
    {
        void Notify(string message); // Sends a notification with a message
    }
}

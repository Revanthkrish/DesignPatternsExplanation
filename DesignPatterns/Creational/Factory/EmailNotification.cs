using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    // Concrete implementation for email notification
    public class EmailNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }
}

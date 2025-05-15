using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Factory
{
    // Concrete implementation for SMS notification
    public class SmsNotification : INotification
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }
}

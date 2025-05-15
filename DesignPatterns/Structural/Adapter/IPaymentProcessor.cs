using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    // This is the interface expected by your system
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}

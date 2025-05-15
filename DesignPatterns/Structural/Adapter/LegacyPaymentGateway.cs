using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    // This is a legacy system or external SDK
    public class LegacyPaymentGateway
    {
        public void MakeTransaction(string currency, double amt)
        {
            Console.WriteLine($"Legacy Payment: {amt} {currency} processed.");
        }
    }
}

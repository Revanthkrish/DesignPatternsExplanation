using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Strategy
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    // Concrete Strategy 2
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    // Concrete Strategy 3
    public class CryptoPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Cryptocurrency.");
        }
    }

}

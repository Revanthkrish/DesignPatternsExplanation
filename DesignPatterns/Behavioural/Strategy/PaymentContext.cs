using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy? _strategy;

        public void SetStrategy(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            if (_strategy == null)
            {
                Console.WriteLine("Payment strategy not set.");
                return;
            }
            _strategy.Pay(amount);
        }
    }
}

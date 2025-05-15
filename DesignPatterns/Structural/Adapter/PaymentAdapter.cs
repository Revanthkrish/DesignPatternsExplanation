using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Adapter
{
    // This adapter allows LegacyPaymentGateway to be used where IPaymentProcessor is expected
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly LegacyPaymentGateway _legacyGateway;

        public PaymentAdapter(LegacyPaymentGateway legacyGateway)
        {
            _legacyGateway = legacyGateway;
        }

        public void ProcessPayment(decimal amount)
        {
            // Adapter translates the call
            _legacyGateway.MakeTransaction("USD", (double)amount);
        }
    }
}

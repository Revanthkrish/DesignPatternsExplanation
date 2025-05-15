using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    public class ExpressShippingDecorator : InvoiceDecorator
    {
        public ExpressShippingDecorator(InVoiceD invoice) : base(invoice) { }

        public override string GetDescription()
        {
            return _invoice.GetDescription() + " + Express Shipping";
        }

        public override decimal GetTotal()
        {
            return _invoice.GetTotal() + 100m;
        }
    }
}

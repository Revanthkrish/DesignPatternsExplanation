using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    // Add-on: Gift wrapping
    public class GiftWrapDecorator : InvoiceDecorator
    {
        public GiftWrapDecorator(InVoiceD invoice) : base(invoice) { }

        public override string GetDescription()
        {
            return _invoice.GetDescription() + " + Gift Wrap";
        }

        public override decimal GetTotal()
        {
            return _invoice.GetTotal() + 25m;
        }
    }
}

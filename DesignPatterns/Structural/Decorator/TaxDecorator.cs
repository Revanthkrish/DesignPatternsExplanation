using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    // Add-on: Tax
    public class TaxDecorator : InvoiceDecorator
    {
        public TaxDecorator(InVoiceD invoice) : base(invoice) { }

        public override string GetDescription()
        {
            return _invoice.GetDescription() + " + Tax";
        }

        public override decimal GetTotal()
        {
            return _invoice.GetTotal() * 1.18m; // 18% GST
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    // Base class for all decorators
    public abstract class InvoiceDecorator : InVoiceD
    {
        protected InVoiceD _invoice;

        public InvoiceDecorator(InVoiceD invoice)
        {
            _invoice = invoice;
        }

        public virtual string GetDescription()
        {
            return _invoice.GetDescription();
        }

        public virtual decimal GetTotal()
        {
            return _invoice.GetTotal();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    // Common interface for all invoice items
    public interface IInvoiceComponent
    {
        void Display(int indent = 0);
        decimal GetTotal();
    }
}

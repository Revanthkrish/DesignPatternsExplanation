using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ProtoType
{
    // The prototype interface defines a Clone method
    public interface IInvoicePrototype
    {
        IInvoicePrototype Clone(); // Method for cloning the object
    }
}

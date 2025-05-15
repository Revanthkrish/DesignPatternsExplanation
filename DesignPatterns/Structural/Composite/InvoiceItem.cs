using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    // Leaf node – represents an individual invoice item
    public class InvoiceItem : IInvoiceComponent
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public InvoiceItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + $"- {Name}: ${Price}");
        }

        public decimal GetTotal()
        {
            return Price;
        }
    }
}

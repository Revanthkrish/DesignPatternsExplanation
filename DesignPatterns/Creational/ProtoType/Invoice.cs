using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.ProtoType
{
    // The concrete class implements the Clone method
    public class Invoice1 : IInvoicePrototype
    {
        public string CustomerName { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }

        public Invoice1(string customerName, string product, decimal amount)
        {
            CustomerName = customerName;
            Product = product;
            Amount = amount;
        }

        public void Print()
        {
            Console.WriteLine($"Invoice for {CustomerName}: {Product} - ${Amount}");
        }

        // Shallow clone (deep clone would copy nested references too)
        public IInvoicePrototype Clone()
        {
            return (IInvoicePrototype)this.MemberwiseClone();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    // The complex object we want to build step by step
    public class Invoice
    {
        public string? Header { get; set; }
        public string? CustomerDetails { get; set; }
        public string? ItemDetails { get; set; }
        public string? TaxDetails { get; set; }
        public string? Footer { get; set; }

        public void Show()
        {
            Console.WriteLine("Invoice:");
            Console.WriteLine(Header);
            Console.WriteLine(CustomerDetails);
            Console.WriteLine(ItemDetails);
            Console.WriteLine(TaxDetails);
            Console.WriteLine(Footer);
        }
    }
}

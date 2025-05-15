using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    // Concrete implementation for a full invoice builder
    public class DetailedInvoiceBuilder : IInvoiceBuilder
    {
        private Invoice _invoice = new Invoice();

        public void BuildHeader()
        {
            _invoice.Header = "== Tax Invoice ==";
        }

        public void BuildCustomerDetails()
        {
            _invoice.CustomerDetails = "Customer: John Doe, Address: 123 Main Street";
        }

        public void BuildItemDetails()
        {
            _invoice.ItemDetails = "Item: Laptop, Quantity: 1, Price: $1500";
        }

        public void BuildTaxDetails()
        {
            _invoice.TaxDetails = "GST: $150, Total: $1650";
        }

        public void BuildFooter()
        {
            _invoice.Footer = "Thank you for your purchase!";
        }

        public Invoice GetInvoice()
        {
            return _invoice;
        }
    }
}

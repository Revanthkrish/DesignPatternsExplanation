using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    public interface IInvoiceBuilder
    {
        void BuildHeader();
        void BuildCustomerDetails();
        void BuildItemDetails();
        void BuildTaxDetails();
        void BuildFooter();
        Invoice GetInvoice(); // Returns the built invoice
    }
}

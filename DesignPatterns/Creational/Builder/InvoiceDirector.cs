using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    // Director controls the construction process using the builder
    public class InvoiceDirector
    {
        private readonly IInvoiceBuilder _builder;

        public InvoiceDirector(IInvoiceBuilder builder)
        {
            _builder = builder;
        }

        public void BuildFullInvoice()
        {
            _builder.BuildHeader();
            _builder.BuildCustomerDetails();
            _builder.BuildItemDetails();
            _builder.BuildTaxDetails();
            _builder.BuildFooter();
        }
    }
}

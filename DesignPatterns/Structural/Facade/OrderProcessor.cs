using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    internal class OrderProcessor
    {
        private readonly PaymentService _payment;
        private readonly InventoryService _inventory;
        private readonly InvoiceService _invoice;
        private readonly EmailService _email;

        public OrderProcessor()
        {
            _payment = new PaymentService();
            _inventory = new InventoryService();
            _invoice = new InvoiceService();
            _email = new EmailService();
        }

        // Unified method that hides subsystem complexity
        public void PlaceOrder(string item, string customer, string email, string paymentType)
        {
            Console.WriteLine("=== Placing Order ===");
            _inventory.CheckStock(item);
            _payment.ProcessPayment(paymentType);
            _invoice.GenerateInvoice(customer);
            _email.SendConfirmation(email);
            Console.WriteLine("Order placed successfully.\n");
        }
    }
}

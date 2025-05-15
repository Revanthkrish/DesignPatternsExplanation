using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Facade
{
    // Subsystem: Payment
    public class PaymentService
    {
        public void ProcessPayment(string paymentType)
        {
            Console.WriteLine($"Payment processed via {paymentType}.");
        }
    }

    // Subsystem: Inventory
    public class InventoryService
    {
        public void CheckStock(string item)
        {
            Console.WriteLine($"{item} is in stock.");
        }
    }

    // Subsystem: Invoice
    public class InvoiceService
    {
        public void GenerateInvoice(string customer)
        {
            Console.WriteLine($"Invoice generated for {customer}.");
        }
    }

    // Subsystem: Notification
    public class EmailService
    {
        public void SendConfirmation(string email)
        {
            Console.WriteLine($"Confirmation email sent to {email}.");
        }
    }
}

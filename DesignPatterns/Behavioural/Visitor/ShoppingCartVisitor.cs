using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    // Concrete Visitor
    public class ShoppingCartVisitor : IVisitor
    {
        private int _totalCost = 0;

        public void Visit(Book book)
        {
            Console.WriteLine($"Book: {book.Title}, Price: {book.Price} INR");
            _totalCost += book.Price;
        }

        public void Visit(Fruit fruit)
        {
            int cost = fruit.PricePerKg * fruit.Weight;
            Console.WriteLine($"Fruit: {fruit.Name}, Cost: {cost} INR");
            _totalCost += cost;
        }

        public int GetTotalCost()
        {
            return _totalCost;
        }
    }
}

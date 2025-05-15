using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    // Concrete Element 1
    public class Book : IItemElement
    {
        public string Title { get; }
        public int Price { get; }

        public Book(string title, int price)
        {
            Title = title;
            Price = price;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    // Concrete Element 2
    public class Fruit : IItemElement
    {
        public string Name { get; }
        public int PricePerKg { get; }
        public int Weight { get; } // in kg

        public Fruit(string name, int pricePerKg, int weight)
        {
            Name = name;
            PricePerKg = pricePerKg;
            Weight = weight;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

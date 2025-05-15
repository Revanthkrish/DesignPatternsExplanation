using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Composite
{
    // Composite node – can contain multiple items or bundles
    public class InvoiceBundle : IInvoiceComponent
    {
        public string Name { get; set; }
        private List<IInvoiceComponent> _components = new List<IInvoiceComponent>();

        public InvoiceBundle(string name)
        {
            Name = name;
        }

        public void Add(IInvoiceComponent component)
        {
            _components.Add(component);
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + $"[Bundle: {Name}]");
            foreach (var component in _components)
            {
                component.Display(indent + 2);
            }
        }

        public decimal GetTotal()
        {
            return _components.Sum(c => c.GetTotal());
        }
    }
}

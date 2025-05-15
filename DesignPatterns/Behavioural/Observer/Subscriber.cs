using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class Subscriber : IObserver
    {
        public string Name { get; private set; }

        public Subscriber(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received news update: {message}");
        }
    }
}

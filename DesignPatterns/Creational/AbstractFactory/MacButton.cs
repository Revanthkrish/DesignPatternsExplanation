using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Mac-style button implementation
    public class MacButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Mac button.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Windows-style button implementation
    public class WindowsButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering a Windows button.");
        }
    }
}

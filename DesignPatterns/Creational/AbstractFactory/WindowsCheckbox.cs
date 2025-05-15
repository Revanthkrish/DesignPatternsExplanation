using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Windows-style checkbox implementation
    public class WindowsCheckbox : ICheckbox
    {
        public void Select()
        {
            Console.WriteLine("Selecting a Windows checkbox.");
        }
    }
}

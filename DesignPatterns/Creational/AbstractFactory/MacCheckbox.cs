using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Mac-style checkbox implementation
    public class MacCheckbox : ICheckbox
    {
        public void Select()
        {
            Console.WriteLine("Selecting a Mac checkbox.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Abstract factory to create UI elements
    public interface IGUIFactory
    {
        IButton CreateButton();        // Factory method for buttons
        ICheckbox CreateCheckbox();    // Factory method for checkboxes
    }
}

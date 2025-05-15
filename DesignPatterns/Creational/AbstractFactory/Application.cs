using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    public class Application
    {
        private readonly IButton _button;
        private readonly ICheckbox _checkbox;

        public Application(IGUIFactory factory)
        {
            _button = factory.CreateButton();       // Use factory to get button
            _checkbox = factory.CreateCheckbox();   // Use factory to get checkbox
        }

        public void RenderUI()
        {
            _button.Render();       // Call common interface method
            _checkbox.Select();     // Call common interface method
        }
    }
}

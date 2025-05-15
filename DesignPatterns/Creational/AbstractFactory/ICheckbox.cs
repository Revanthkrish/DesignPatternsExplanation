using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.AbstractFactory
{
    // Common interface for Checkbox
    public interface ICheckbox
    {
        void Select();  // Toggle checkbox state
    }
}

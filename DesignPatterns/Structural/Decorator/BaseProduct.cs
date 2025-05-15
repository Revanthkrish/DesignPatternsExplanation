using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Decorator
{
    // The base product being billed
    public class BaseProduct : InVoiceD
    {
        public string GetDescription()
        {
            return "Base Product";
        }

        public decimal GetTotal()
        {
            return 1000m;
        }
    }
}

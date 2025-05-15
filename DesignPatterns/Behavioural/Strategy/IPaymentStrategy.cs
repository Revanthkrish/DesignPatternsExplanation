using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Strategy
{
    // Strategy Interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}

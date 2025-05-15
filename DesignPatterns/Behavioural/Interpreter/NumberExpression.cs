using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Interpreter
{
    public class NumberExpression : IExpression
    {
        private int _number;

        public NumberExpression(int number)
        {
            _number = number;
        }

        public int Interpret()
        {
            return _number;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.State
{
    public class Context
    {
        private IState _state;

        public Context(IState state)
        {
            SetState(state);
        }

        public void SetState(IState state)
        {
            _state = state;
            Console.WriteLine($"State changed to: {_state.GetType().Name}");
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}

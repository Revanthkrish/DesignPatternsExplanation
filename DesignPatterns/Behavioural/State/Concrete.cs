using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.State
{
    public class LoggedOutState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("User is logged out. Logging in...");
            context.SetState(new LoggedInState());
        }
    }

    // Concrete State: LoggedInState
    public class LoggedInState : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("User is logged in. Logging out...");
            context.SetState(new LoggedOutState());
        }
    }
}

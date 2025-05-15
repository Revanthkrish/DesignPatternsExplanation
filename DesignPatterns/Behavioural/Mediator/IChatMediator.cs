using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public interface IChatMediator
    {
        void SendMessage(string message, User user);
        void RegisterUser(User user);
    }
}

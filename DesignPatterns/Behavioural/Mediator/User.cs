using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public abstract class User
    {
        protected IChatMediator mediator;
        public string Name { get; private set; }

        protected User(IChatMediator mediator, string name)
        {
            this.mediator = mediator;
            this.Name = name;
        }

        public abstract void Send(string message);
        public abstract void Receive(string message, string senderName);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Behavioural.Mediator
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name)
            : base(mediator, name)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            mediator.SendMessage(message, this);
        }

        public override void Receive(string message, string senderName)
        {
            Console.WriteLine($"{Name} received from {senderName}: {message}");
        }
    }
}

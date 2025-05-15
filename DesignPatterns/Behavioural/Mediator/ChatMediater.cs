using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Mediator
{
    public class ChatMediator : IChatMediator
    {
        private readonly List<User> _users = new List<User>();

        public void RegisterUser(User user)
        {
            _users.Add(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                // Skip sending message to the sender itself
                if (user != sender)
                    user.Receive(message, sender.Name);
            }
        }
    }
}

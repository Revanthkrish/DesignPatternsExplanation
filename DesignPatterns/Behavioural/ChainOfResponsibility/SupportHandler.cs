using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler? _next;

        // Set the next handler in the chain
        public void SetNext(SupportHandler next)
        {
            _next = next;
        }

        // Handle the request
        public abstract void HandleRequest(string issueType);
    }
}

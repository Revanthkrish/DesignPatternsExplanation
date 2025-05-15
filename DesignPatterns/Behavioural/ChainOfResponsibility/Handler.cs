using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.ChainOfResponsibility
{
    public class Tier1Support : SupportHandler
    {
        public override void HandleRequest(string issueType)
        {
            if (issueType == "Basic")
            {
                Console.WriteLine("Tier 1 handled the basic issue.");
            }
            else
            {
                Console.WriteLine("Tier 1 escalated the issue.");
                _next?.HandleRequest(issueType);
            }
        }
    }

    public class Tier2Support : SupportHandler
    {
        public override void HandleRequest(string issueType)
        {
            if (issueType == "Intermediate")
            {
                Console.WriteLine("Tier 2 handled the intermediate issue.");
            }
            else
            {
                Console.WriteLine("Tier 2 escalated the issue.");
                _next?.HandleRequest(issueType);
            }
        }
    }

    public class Manager : SupportHandler
    {
        public override void HandleRequest(string issueType)
        {
            if (issueType == "Critical")
            {
                Console.WriteLine("Manager handled the critical issue.");
            }
            else
            {
                Console.WriteLine("Manager: Cannot handle this issue.");
            }
        }
    }
}

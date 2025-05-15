using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singeleton
{
    public class SingeletonTest
    {
        public static void Run()
        {
            Logger logger1 = Logger.Instance;
            Logger logger2 = Logger.Instance;

            logger1.Log("First Log Entry");
            logger2.Log("Second Log Entry");

            Console.WriteLine($"Same Instance:{ReferenceEquals(logger1, logger2)}");
        }
    }
}

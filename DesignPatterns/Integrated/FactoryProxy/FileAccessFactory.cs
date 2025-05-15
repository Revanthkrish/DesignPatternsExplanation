using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Integrated.FactoryProxy
{
    public static class FileAccessFactory
    {
        public static IFileAccesor CreateFileAccessor(string role)
        {
            // Return a proxy instead of real object for access control
            return new FileAccessProxy1(role);
        }
    }
}

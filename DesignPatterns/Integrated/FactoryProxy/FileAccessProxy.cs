using DesignPatterns.Structural.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Integrated.FactoryProxy
{
    public class FileAccessProxy1 : IFileAccesor
    {
        private readonly FileAccessor _realFileAccessor;
        private readonly string _userRole;

        public FileAccessProxy1(string userRole)
        {
            _realFileAccessor = new FileAccessor();
            _userRole = userRole;
        }

        public void OpenFile(string filename)
        {
            if (_userRole == "Admin")
            {
                _realFileAccessor.OpenFile(filename);
            }
            else
            {
                Console.WriteLine($"Access Denied: '{_userRole}' role does not have permission to open files.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class FileAccessProxy : IFileAccessor
    {
        private readonly FileAccessor _realFileAccessor;
        private readonly string _userRole;

        public FileAccessProxy(string userRole)
        {
            _realFileAccessor = new FileAccessor();
            _userRole = userRole;
        }

        public void OpenFile(string filename)
        {
            // Add access control logic
            if (_userRole == "Admin")
            {
                _realFileAccessor.OpenFile(filename); // Allow access
            }
            else
            {
                Console.WriteLine($"Access denied for '{_userRole}'. Only admins can open files.");
            }
        }
    }
}

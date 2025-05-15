using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public class FileAccessor : IFileAccessor
    {
        public void OpenFile(string filename)
        {
            Console.WriteLine($"File '{filename}' has been opened.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    public interface IFileAccessor
    {
        void OpenFile(string filename);
    }
}

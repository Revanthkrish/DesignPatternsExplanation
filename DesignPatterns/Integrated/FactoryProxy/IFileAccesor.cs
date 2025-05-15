using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Integrated.FactoryProxy
{
    public interface IFileAccesor
    {
        void OpenFile(string filename);
    }
}

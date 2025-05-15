using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator
{
    public interface IIterator<T>
    {
        T First();
        T Next();
        bool IsDone { get; }
        T CurrentItem { get; }
    }
}

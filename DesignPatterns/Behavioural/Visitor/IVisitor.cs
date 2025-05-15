using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Visitor
{
    public interface IVisitor
    {
        void Visit(Book book);
        void Visit(Fruit fruit);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Memento
{
    // Memento - stores the state
    public class EditorMemento
    {
        public string Content { get; private set; }

        public EditorMemento(string content)
        {
            Content = content;
        }
    }
}

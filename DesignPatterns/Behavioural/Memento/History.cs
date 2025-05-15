using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Memento
{
    public class History
    {
        private Stack<EditorMemento> _history = new Stack<EditorMemento>();

        public void Save(EditorMemento memento)
        {
            _history.Push(memento);
        }

        public EditorMemento Undo()
        {
            if (_history.Count > 0)
                return _history.Pop();
            return null;
        }
    }
}

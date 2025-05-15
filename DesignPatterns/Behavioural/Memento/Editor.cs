using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Memento
{
    // Originator - creates and restores mementos
    public class Editor
    {
        private string _content;

        public void Type(string words)
        {
            _content += words;
        }

        public string GetContent()
        {
            return _content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(_content);
        }

        public void Restore(EditorMemento memento)
        {
            _content = memento.Content;
        }
    }
}

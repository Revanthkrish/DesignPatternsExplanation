using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Iterator
{
    // Concrete Iterator
    public class Iterator<T> : IIterator<T>
    {
        private readonly IList<T> _collection;
        private int _current = 0;

        public Iterator(IList<T> collection)
        {
            _collection = collection;
        }

        public T First()
        {
            _current = 0;
            return _collection[_current];
        }

        public T Next()
        {
            _current++;
            if (!IsDone)
                return _collection[_current];
            else
                return default;
        }

        public bool IsDone => _current >= _collection.Count;

        public T CurrentItem => _collection[_current];
    }
}

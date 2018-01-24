using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStudy
{
    class EducNumerator : IIterator
    {
        IEnumerable _collection;
        int index;

        public EducNumerator(IEnumerable collection)
        {
            _collection = collection;
        }

        public bool HasNext()
        {
            return index < _collection.Count;
        }

        public AbstractStudy Next()
        {
            return _collection[index++];
        }
    }
}

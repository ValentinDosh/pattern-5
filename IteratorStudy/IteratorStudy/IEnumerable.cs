using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStudy
{
    interface IEnumerable
    {
        IIterator CreateNumerator();
        int Count { get; }
        AbstractStudy this[int index] { get; }
    }
}

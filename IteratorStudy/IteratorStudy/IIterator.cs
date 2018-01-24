using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStudy
{
    interface IIterator
    {
        AbstractStudy Next();
        bool HasNext();
    }
}

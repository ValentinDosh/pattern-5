using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStudy
{
    class EducEstablishments : IEnumerable
    {
        AbstractStudy[] _items;

        public EducEstablishments()
        {
            _items = new AbstractStudy[]
            {
                new School{Name = "№167"},
                new Univercity{Name = "БНТУ"},
                new School{Name = "№123"},
                new Univercity{Name = "БГУИР"}
            };
        }

        public IIterator CreateNumerator()
        {
            return new EducNumerator(this);
        }

        public AbstractStudy this[int index]
        {
            get
            {
                return _items[index];
            }
        }

        public int Count
        {
            get
            {
                return _items.Length;
            }
        }

       
    }
}

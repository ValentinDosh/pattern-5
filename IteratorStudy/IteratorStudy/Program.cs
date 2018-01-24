using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            EducEstablishments study = new EducEstablishments();
            IIterator iterator1 = study.CreateNumerator();

            while (iterator1.HasNext())
            {
                Console.WriteLine(iterator1.Next().Name);
            }
            Console.ReadLine();
        }
    }
}

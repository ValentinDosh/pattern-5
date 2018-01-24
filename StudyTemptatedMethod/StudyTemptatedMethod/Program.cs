using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTemptatedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractStud school = new School();
            AbstractStud univer = new Univrcity();

            school.Studing();
            univer.Studing();

            Console.ReadLine();
        }
    }
}

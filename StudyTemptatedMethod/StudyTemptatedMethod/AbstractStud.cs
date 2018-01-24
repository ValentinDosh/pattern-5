using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTemptatedMethod
{
    abstract class AbstractStud
    {
        public void Studing()
        {
            Enter();
            Study();
            PassExams();
            GetAttestat();
        }

        abstract public void Enter();

        abstract public void Study();

        abstract public void PassExams();

        abstract public void GetAttestat();
    }
}

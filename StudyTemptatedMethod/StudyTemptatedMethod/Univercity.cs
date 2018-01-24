using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTemptatedMethod
{
    class Univrcity : AbstractStud
    {
        public override void Enter()
        {
            Console.WriteLine("Учащиеся оступаю в универ по результатам вступительных экзаменов и ср. балла атестата");
        }

        public override void Study()
        {
            Console.WriteLine("Посещаем лекции, сдаем лабороторные, курсовые проекты");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаем дипломную работу");
        }

        public override void GetAttestat()
        {
            Console.WriteLine("Получаем Диплом");
        }
    }
}

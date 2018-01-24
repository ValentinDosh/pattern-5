using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTemptatedMethod
{
    class School : AbstractStud
    {
        public override void Enter()
        {
            Console.WriteLine("Дети идут в первый класс");
        }

        public override void Study()
        {
            Console.WriteLine("Ходим на уроки, делаем зарядку утром под музыку, сдаем домашку");
        }

        public override void PassExams()
        {
            Console.WriteLine("Сдаем Гос. Экзамены");
        }

        public override void GetAttestat()
        {
            Console.WriteLine("Получаем атестат");
        }

       

        
    }
}

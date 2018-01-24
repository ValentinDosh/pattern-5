using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObsirvirTime
{
    class TimiUpdate
    {
        IObservable _a;
        
        public TimiUpdate(IObservable a)
        {
            _a = a;
        }

        // метод будет менять состояние каждые 5 секунд
        public void Change()
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(5000);
                ((A)_a).Change();
                Console.WriteLine("{0} запись из 5", i + 1);
            }
            
        }
    }
}

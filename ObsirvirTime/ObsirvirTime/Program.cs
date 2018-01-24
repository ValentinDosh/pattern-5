using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ObsirvirTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // создали наблюдаемый объект
            // подписали наблюдателей
            IObservable obable = new A(@"d:\write.txt");
            IObserver observer1 = new ObserverValue("Наблюдатель1", obable);
            IObserver observer2 = new ObserverValue("Наблюдатель2", obable);

            // передали наблюдаемый объект нашему менятелю
            TimiUpdate t = new TimiUpdate(obable);
            // запускаем наш менятель
            t.Change();
            Console.ReadLine();
        }
    }
}

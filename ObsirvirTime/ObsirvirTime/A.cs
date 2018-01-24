using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// не работают все клавиши, оэтому такие имена

namespace ObsirvirTime
{
    class A : IObservable
    {
        // имя файла для записи
        public string NameFile { get; set; }
        public int Valui { get; set; }
        // наши наблюдатели
        List<IObserver> _observers;


        public A(string nameFile)
        {
            NameFile = nameFile;
            _observers = new List<IObserver>();
            // создаем файл на диске
            using (File.Create(NameFile)) { }
        }

        public void AddObsirvir(IObserver o)
        {
            _observers.Add(o);
        }

        public void NotifyObservers()
        {
            foreach (var item in _observers)
            {
                item.Update(Valui);
            }
        }

        public void RemoveObsirvir(IObserver o)
        {
            _observers.Remove(o);
        }

        // метод меняющий состояние
        // его вызываем в TimeUpdate
        public void Change()
        {
            Random r = new Random();
            Valui = r.Next(0, 100);
            NotifyObservers();
        }
    }
}

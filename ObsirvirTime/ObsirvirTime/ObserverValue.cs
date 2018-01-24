using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsirvirTime
{
    class ObserverValue : IObserver
    {
        IObservable _obsirvabli;
        public string Name { get; set; }

        public ObserverValue(string name, IObservable obsivabli)
        {
            Name = name;
            _obsirvabli = obsivabli;
            _obsirvabli.AddObsirvir(this);
        }

        public void Update(int value)
        {
            // сформируем строку для записи
            string write = "Наблюдатель " + this.Name + " информирует, что состояние обьекта изменилось, Value = " +
                +value + " время изменения: " + DateTime.Now.ToString();

            using (StreamWriter st = new StreamWriter(((A)_obsirvabli).NameFile, true))
            {
                st.WriteLine(write);
            }
                
        }

        // отписаться
        void Target()
        {
            _obsirvabli.RemoveObsirvir(this);
            _obsirvabli = null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsirvirTime
{
    interface IObservable
    {
        void AddObsirvir(IObserver o);
        void RemoveObsirvir(IObserver o);
        void NotifyObservers();
    }
}

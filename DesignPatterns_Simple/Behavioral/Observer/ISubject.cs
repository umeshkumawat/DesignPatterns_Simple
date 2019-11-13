using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Observer
{
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyObserver();
    }
}

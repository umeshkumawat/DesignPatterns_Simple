using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DesignPatterns_Simple.Observer
{
    public class StockGrabber : ISubject
    {
        private List<IObserver> _observers;
        private double _ibmPrice;
        private double _applPrice;
        private double _googPrice;

        public StockGrabber()
        {
            _observers = new List<IObserver>();
        }
        public void NotifyObserver()
        {
            _observers.ForEach(o => o.Update(_ibmPrice, _applPrice, _googPrice));
        }

        public void Register(IObserver newObserver)
        {
            _observers.Add(newObserver);
        }

        public void Unregister(IObserver deleteObserver)
        {
            _observers.Remove(deleteObserver);
        }

        public void SetIBMPrice(double newIBMPrice)
        {
            _ibmPrice = newIBMPrice;
            NotifyObserver();
        }

        public void SetAPPLPrice(double newAPPLPrice)
        {
            _applPrice = newAPPLPrice;
            NotifyObserver();
        }

        public void SetGOOGPrice(double newGOOGPrice)
        {
            _googPrice = newGOOGPrice;
            NotifyObserver();
        }
    }
}

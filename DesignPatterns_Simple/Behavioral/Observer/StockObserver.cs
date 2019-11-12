using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Observer
{
    public class StockObserver : IObserver
    {
        private ISubject _stockGrabber;
        private double _ibmPrice;
        private double _applPrice;
        private double _googPrice;

        public StockObserver(ISubject stockGrabber)
        {
            _stockGrabber = stockGrabber;
            _stockGrabber.Register(this);
        }
        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            _ibmPrice = ibmPrice;
            _applPrice = aaplPrice;
            _googPrice = googPrice;

            PrintThePrices();
        }

        void PrintThePrices()
        {
            Console.WriteLine($"IBM: {_ibmPrice} \nAPPL: {_applPrice} \nGOOG: {_googPrice}");
        }

    }
}

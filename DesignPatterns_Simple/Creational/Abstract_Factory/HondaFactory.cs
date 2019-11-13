using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Creational.Abstract_Factory
{
    public class HondaFactory : IVehicleFactory
    {
        public IBike GetBike(string bike)
        {
            if (bike == "sports")
                return new SportsBike();
            else if (bike == "regular")
                return new RegularBike();
            else
                throw new ApplicationException($"Vehicla '{bike}' cannot be created");
        }

        public IScooter GetScooter(string scooter)
        {
            if (scooter == "sports")
                return new Scooty();
            else if (scooter == "regular")
                return new RegularScooter();
            else
                throw new ApplicationException($"Vehicla '{scooter}' cannot be created");
        }
    }
}

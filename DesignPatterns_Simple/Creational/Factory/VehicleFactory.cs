using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Factory
{
    public class VehicleFactory
    {
        public IVehicle GetVehicle(string type)
        {
            IVehicle vehicle = null;

            if (type == "car")
                vehicle = new Car();
            else if (type == "truck")
                vehicle = new Truck();

            return vehicle;
        }
    }
}

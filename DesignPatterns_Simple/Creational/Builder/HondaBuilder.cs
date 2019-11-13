using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Creational.Builder
{
    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        public void SetModel()
        {
            vehicle.Model = "Honda";
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Stroke";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "125 Km/hr";
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
            vehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return vehicle;
        }
    }
}

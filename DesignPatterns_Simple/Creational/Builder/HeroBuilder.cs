using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Creational.Builder
{
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();

        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        public void SetAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Rear Mirror");
        }

        public void SetBody()
        {
            vehicle.Body = "Plastic";
        }

        public void SetEngine()
        {
            vehicle.Engine = "4 Stroke";
        }

        public void SetModel()
        {
            vehicle.Model = "Hero";
        }

        public void SetTransmission()
        {
            vehicle.Transmission = "120 km/hr";
        }
    }
}

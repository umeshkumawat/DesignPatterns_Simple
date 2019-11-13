using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Creational.Builder
{
    public class VehicleCreator
    {
        private IVehicleBuilder _builder;

        public Vehicle GetVehicle { get { return _builder.GetVehicle(); }  }
        public VehicleCreator(IVehicleBuilder builder)
        {
            _builder = builder;
        }

        public void CreateVehicle()
        {
            _builder.SetModel();
            _builder.SetEngine();
            _builder.SetBody();
            _builder.SetTransmission();
            _builder.SetAccessories();
        }
    }
}

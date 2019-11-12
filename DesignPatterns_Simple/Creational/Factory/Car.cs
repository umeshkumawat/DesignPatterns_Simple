using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Factory
{
    public class Car : IVehicle
    {
        public void MyIdentity()
        {
            Console.WriteLine("I'm a Car");
        }
    }
}

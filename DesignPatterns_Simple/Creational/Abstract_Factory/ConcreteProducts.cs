using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Creational.Abstract_Factory
{
    public class RegularBike : IBike
    {
        string _name;
        public string Name
        {
            get { return $"Regular Bike - {_name}";}
            set { _name = value; }
        }
        
    }
    public class SportsBike : IBike
    {
        string _name;
        public string Name
        {
            get { return $"Sports Bike - {_name}"; }
            set { _name = value; }
        }
    }
    public class RegularScooter : IScooter
    {
        string _name;
        public string Name
        {
            get { return $"Regular Scooter - {_name}"; }
            set { _name = value; }
        }
    }
    public class Scooty : IScooter
    {
        string _name;
        public string Name
        {
            get { return $"Scooty - {_name}"; }
            set { _name = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Decorator
{
    public class PlainPizza : IPizza
    {
        public double getCost()
        {
            Console.WriteLine($"Cost of Dough {4.00}");
            return 4.00;
        }

        public string getDescription()
        {
            return "Thin Dough";
        }
    }
}

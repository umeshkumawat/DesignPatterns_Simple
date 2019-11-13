using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza newPizza) : base(newPizza)
        { }

        public override double getCost()
        {
            Console.WriteLine($"Cost of Mozz {.50}");
            return tempPizza.getCost() + .50;
        }

        public override string getDescription()
        {
            return tempPizza.getDescription() + ", mozzarella";
        }
    }
}

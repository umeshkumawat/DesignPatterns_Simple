using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Decorator
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza newPizza) : base(newPizza)
        {  }

        public override double getCost()
        {
            Console.WriteLine($"Cost of Sauce {.35}");
            return tempPizza.getCost() + .35;
        }

        public override string getDescription()
        {
            return tempPizza.getDescription() + ", tomato sauce";
        }
    }
}

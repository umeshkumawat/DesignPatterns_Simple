using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Decorator
{
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza tempPizza;

        public ToppingDecorator(IPizza newPizza)
        {
            tempPizza = newPizza;
        }

        public virtual double getCost()
        {
            return tempPizza.getCost();
        }

        public virtual string getDescription()
        {
            return tempPizza.getDescription();
        }
    }
}

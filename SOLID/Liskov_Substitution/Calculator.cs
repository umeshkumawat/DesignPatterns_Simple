using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    public abstract class Calculator
    {
        public abstract int Calculate(params int[] numbers);
    }
}

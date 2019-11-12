using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    public class SumCalculator : Calculator
    {
        public override int Calculate(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}

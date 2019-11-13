using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov_Substitution
{
    public class EvenNumberSumCalculator : Calculator
    {
        public override int Calculate(params int[] numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum();
        }
    }
}

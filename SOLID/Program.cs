
using SOLID.Liskov_Substitution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator obj = new SumCalculator();
            Console.WriteLine(obj.Calculate(1,2,3,4,5,6));

            obj = new EvenNumberSumCalculator();
            Console.WriteLine(obj.Calculate(1, 2, 3, 4, 5, 6));

            Console.ReadLine();
        }
    }
}

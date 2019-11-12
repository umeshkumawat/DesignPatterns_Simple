using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Chain_Of_Responsibility
{
    public class Divide : IChain
    {
        IChain _nextChain;
        public void Calculate(Number number)
        {
            if (number.CalcWanted == "Div")
            {
                Console.WriteLine("DIV");
            }
            else
            {
                Console.WriteLine("NOT RECOGNIZE");
            }
        }

        public void NextInChain(IChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}

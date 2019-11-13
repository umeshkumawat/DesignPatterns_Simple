using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Chain_Of_Responsibility
{
    public class Subtract : IChain
    {
        IChain _nextChain;
        public void Calculate(Number number)
        {
            if (number.CalcWanted == "Sub")
            {
                Console.WriteLine("SUB");
            }
            else
            {
                _nextChain.Calculate(number);
            }
        }

        public void NextInChain(IChain nextChain)
        {
            _nextChain = nextChain;
        }
    }
}

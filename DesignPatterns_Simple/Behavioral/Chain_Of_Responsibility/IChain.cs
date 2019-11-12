using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Chain_Of_Responsibility
{
    public interface IChain
    {
        void NextInChain(IChain nextChain);
        void Calculate(Number number);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Builder
{
    public interface IRobotBuilder
    {
        void BuildRobotHead();
        void BuildRobotTorso();
        void BuildRobotArms();
        void BuildRobotLegs();
    }
}

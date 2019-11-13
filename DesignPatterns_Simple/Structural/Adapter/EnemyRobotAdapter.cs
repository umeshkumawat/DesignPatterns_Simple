using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Adapter
{
    public class EnemyRobotAdapter : IEnemyAttacker
    {
        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot robot)
        {
            theRobot = robot;
        }
        public void AssignDriver(string name)
        {
            theRobot.ReactToHuman(name);
        }

        public void DriveForward()
        {
            theRobot.WalkForward();
        }

        public void FireWeapon()
        {
            theRobot.SmashWithHands();
        }
    }
}

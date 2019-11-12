using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Adapter
{
    public class EnemyRobot
    {
        Random generator = new Random();

        public void SmashWithHands()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine($"Enemy Robot Causes {attackDamage} Damage With Its Hands");
        }

        public void WalkForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine($"Enemy Robot Forward {movement} Spaces");
        }

        public void ReactToHuman(string driverName)
        {
            Console.WriteLine($"Enemy Robot Tramps on {driverName}");
        }
    }
}

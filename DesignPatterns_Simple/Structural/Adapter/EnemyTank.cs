using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Simple.Adapter
{
    public class EnemyTank : IEnemyAttacker
    {
        Random generator = new Random();
        public void AssignDriver(string name)
        {
            Console.WriteLine($"{name} is driving the tank.");
        }

        public void DriveForward()
        {
            int movement = generator.Next(5) + 1;
            Console.WriteLine($"Enemy Tank Moves {movement} spaces");
        }

        public void FireWeapon()
        {
            int attackDamage = generator.Next(10) + 1;
            Console.WriteLine($"Enemy Tank Does {attackDamage} Damage");
        }
    }
}

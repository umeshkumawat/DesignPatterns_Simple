using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns_Simple.Adapter;
using DesignPatterns_Simple.Observer;
using DesignPatterns_Simple.Chain_Of_Responsibility;
using DesignPatterns_Simple.Singleton;
using DesignPatterns_Simple.Factory;
using DesignPatterns_Simple.Decorator;
using DesignPatterns_Simple.Creational.Abstract_Factory;

namespace DesignPatterns_Simple
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ADAPTER DESIGN PATTERN
            /*
            EnemyTank tank = new EnemyTank();
            EnemyRobot robot = new EnemyRobot();
            IEnemyAttacker robotAdapter = new EnemyRobotAdapter(robot);

            robot.ReactToHuman("Paul");
            robot.WalkForward();
            robot.SmashWithHands();


            robotAdapter.AssignDriver("Tim");
            robotAdapter.DriveForward();
            robotAdapter.FireWeapon(); 
            */
            #endregion

            #region OBSERVER DESIGN PATTERN
            /*
            StockGrabber stockGrabber = new StockGrabber();
            StockObserver stockObserver = new StockObserver(stockGrabber);

            stockGrabber.SetIBMPrice(197.00);
            stockGrabber.SetAPPLPrice(677.60);
            stockGrabber.SetGOOGPrice(676.40); 
            */
            #endregion

            #region CHAIN OF RESPONSIBILITY PATTERN
            /*
                Number num = new Number { Num1 = 10, Num2=2, CalcWanted="Div" };
                IChain chain1 = new Add();
                IChain chain2 = new Subtract();
                IChain chain3 = new Multiply();
                IChain chain4 = new Divide();

                chain1.NextInChain(chain2);
                chain2.NextInChain(chain3);
                chain3.NextInChain(chain4);

                chain1.Calculate(num);
                */
            #endregion

            #region SINGLETON PATTERN
            /*
            Logging obj1 = Logging.GetInstance();
            Logging obj2 = Logging.GetInstance();

            Console.WriteLine($"Obj1: {obj1.GetHashCode()} \nObj2: {obj2.GetHashCode()}");
            */
            #endregion

            #region FACTORY PATTERN
            /*
            VehicleFactory vehicleFactory = new VehicleFactory();
            IVehicle vehicle = vehicleFactory.GetVehicle("car");
            vehicle.MyIdentity();

            vehicle = vehicleFactory.GetVehicle("truck");
            vehicle.MyIdentity();
            */
            #endregion

            #region ABSTRACT FACTORY PATTERN
            /*
            IVehicleFactory vehicleFactory = new HeroFactory();
            IBike bike = vehicleFactory.GetBike("regular");
            Console.WriteLine(bike.Name);
            bike = vehicleFactory.GetBike("sports");
            Console.WriteLine(bike.Name);
            */
            #endregion

            #region DECORATOR PATTERN
            /*
            IPizza basicPizza = new Mozzarella(new TomatoSauce(new PlainPizza()));
            Console.WriteLine(basicPizza.getDescription());
            Console.ReadLine(); 
            */
            #endregion

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal class Test
    {
        static void Main(string[] args)
        {
            CheckTest();
        }

        public static void CheckTest()
        {
            IRobotBuilder useRobotBuilder = new UseRobotBuilder();
            RobotEngineer robotEngineer = new RobotEngineer(useRobotBuilder);

            robotEngineer.MakeRobot();
            Robot Robot_1 =  robotEngineer.getRobot();

            ShowResult(Robot_1);
        }
        public static void ShowResult(Robot robot)
        {
            Console.WriteLine("===== Robort Build ====");
            Console.WriteLine($"Robot Head Type:{robot.robotHead}");
            Console.WriteLine($"Robot Arms Type:{robot.robotArms}");
            Console.WriteLine($"Robot Body Type:{robot.robotBody}");
            Console.WriteLine($"Robot Legs Type:{robot.robotLeg}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal class UseRobotBuilder : IRobotBuilder
    {
        private Robot robot;

        public UseRobotBuilder()
        {
            robot = new Robot(); 
        }
        public void MakeRobotHead()
        {
            robot.SetRobotHead("Tin Head");
        }

        public void MakeRobotArms()
        {
            robot.SetRobotArms("Tin arms");
        }

        public void MakeRobotBody()
        {
            robot.SetRobotBody("Steel body");
        }

        public void MakeRobotLegs()
        {
            robot.SetRobotLeg("plastic leg");
        }

        public Robot GetRobot()
        {
            return this.robot;
        }
    }
}

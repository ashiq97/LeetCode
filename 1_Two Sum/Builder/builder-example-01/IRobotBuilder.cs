using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal interface IRobotBuilder
    {
        public void MakeRobotHead();
        public void MakeRobotBody();
        public void MakeRobotArms();
        public void MakeRobotLegs();
        public Robot GetRobot();
    }
}

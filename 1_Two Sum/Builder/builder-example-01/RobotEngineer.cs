using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal class RobotEngineer
    {
        private IRobotBuilder _robotBuilder;
        public RobotEngineer(IRobotBuilder robotBuilder)
        {
            _robotBuilder = robotBuilder; 
        }

        public Robot getRobot()
        {
            return _robotBuilder.GetRobot();
        }

        public void MakeRobot()
        {
            _robotBuilder.MakeRobotHead();
            _robotBuilder.MakeRobotArms();
            _robotBuilder.MakeRobotBody();
            _robotBuilder.MakeRobotLegs();
        }

    }
}

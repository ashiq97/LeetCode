using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal interface IRobotPlan
    {
        public void SetRobotHead(string head);
        public void SetRobotArms(string arms);
        public void SetRobotBody(string body);
        public void SetRobotLeg(string leg);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Builder.builder_example_01
{
    internal class Robot : IRobotPlan
    {
        public string robotHead { get; private set; }
        public string robotBody { get; private set;}
        public string robotArms { get; private set; }
        public string robotLeg { get; private set; }

        public void SetRobotHead(string head)
        {
            robotHead = head;
        }
      
        public void SetRobotArms(string arms)
        {
            robotArms = arms;
        }

        public void SetRobotBody(string body)
        {
            robotBody = body;
        }

        public void SetRobotLeg(string leg)
        {
           robotLeg= leg;
        }

        //public string GetRobotBody()
        //{
        //    return robotBody;
        //}
        //public string GetRobotHead()
        //{
        //    return robotHead;
        //}
        //public string GetRobotLegs()
        //{
        //    return robotLeg;
        //}
        //public string GetRobotArms()
        //{
        //    return robotArms;
        //}
    }
}

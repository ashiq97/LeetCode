using _1_Two_Sum.Builder.builder_example_01;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Singleton
{
    internal class Test
    {
        static void Main(string[] args)
        {
            CheckTest();
        }
        public static void CheckTest()
        {
            try
            {
                int x = 7;
                while(true)
                {
                    x = (x / 2) / x;
                }
            }
            catch (Exception ex)
            {
                var logger = ErrorLogger.GetLogger();
                logger.WriteLog(ex.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode.NeetCode_1
{
    internal class Arraingaing_conins_441
    {
        static void Main(string[] args)
        {
            var coins = 10;
           var output =  ArrangeCoins(coins);
            Console.WriteLine(output);
        }
        private static int ArrangeCoins(int n)
        {
            var c = 0;
            var sum = 0;
            var length = n;
            
            for (int i = 1; i <= length; i++)
            {
                var res = n - i;
                n = res;

                if (res == 0)
                    return i;
                else if (res < 0)
                    return i - 1;
            }

            return c;
        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.Recursion
{
    internal class print1ToN
    {
        static void Main(string[] args)
        {
            var n = 10;
          // printN(n);
            n = 1;
            printN_to_1(n);
        }
        static int printN(int n)
        {

            if (n == 0)
                return 1;

            printN(n-1);
            Console.WriteLine(n);
            return n;
        }
        static int printN_to_1(int n)
        {
            Console.WriteLine(n);

            if (n == 10)
                return 10;

            printN_to_1(n + 1);
            return n;
        }
    }
}

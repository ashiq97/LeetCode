using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _202_happy_number
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = 4;
        //    var s = IsHappy(input);
        //    Console.WriteLine($"Total {s}");
        //}
        public static bool IsHappy(int n)
        {
            var res = 0;
           // var list = new HashSet<int>();
            var list = new List<int>();
            while (!list.Contains(n))
            {
                list.Add(n);
                n = sumOfSquare(n);

                if (n == 1)
                    return true;
            }
            return false;
        }
        private static int sumOfSquare(int n)
        {
            var result = 0;
            while(n!=0)
            {
                var digit = n % 10;
                result += digit * digit;
                n = n / 10;
            }
            return result;
        }
    }
}

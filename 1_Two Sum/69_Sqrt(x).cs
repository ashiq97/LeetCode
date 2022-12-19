using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _69_Sqrt_x_
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[5] { 1, 3, 7, 16, 25 };
        //    var target = 4;

        //    var result = MySqrt(target);


        //    Console.WriteLine($"rest is {result}");
        //}
        public static int MySqrt(int x)
        {
            var start = x;
            var odd_number = 1;
            var result = 1;
            var i = 0;
            while(result >= 0)
            {
                result = start - odd_number;
                if (result >= 0)
                    i++;
                
                start = result;
                odd_number += 2;
                
            }
            return i;
        }
    }
}

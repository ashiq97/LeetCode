using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _367_Valid_Perfect_Square
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[5] { 1, 3, 7, 16, 25 };
        //    var target = 14;

        //    var result = IsPerfectSquare(target);


        //    Console.WriteLine($"result is {result}");
        //}
        public static bool IsPerfectSquare(int num)
        {
            var start = num;
            var odd_number = 1;
            var result = 1;

            while (result >= 0)
            {
                result = start - odd_number;
                if (result == 0)
                    return true;

                start = result;
                odd_number += 2;

            }
            return false;
        }
    }
}

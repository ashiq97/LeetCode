using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode.NeetCode_1
{
    public  class perfectSquare_367
    {
        //static void Main(string[] args)
        //{
        //    var input = 16;
        //    var output = IsPerfectSquare(input);
        //    Console.WriteLine(output);
        //}

        public static bool IsPerfectSquare(int n)
        {
            long left = 1;
            long right = n;
            
            while(left <= right)
            {
                var mid = Convert.ToInt64((left + right) / 2);

                if (mid * mid > n)    // 8*8 = 64 > 16
                    right = mid - 1; // 8-1 = 7
                else if (mid * mid < n) // 2*2 = 4 < 16
                    left = left + 1;
                else
                    return true;
            }
            return false;
        }
    }
}

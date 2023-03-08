 using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _53_Maximum_Subarray
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[] { -2, 1,-3,4,-1,2,1,-5,4};
        //    var result = maxSubArray(nums);
        //    Console.WriteLine($"{result}");
        //}
        static int maxSubArray(int[] nums)
        {
            var maxSub = nums[0];
            var currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(currentSum<0)
                {
                    currentSum = 0;
                }
                currentSum = currentSum + nums[i];
                maxSub = Math.Max(maxSub, currentSum);
            }

            return maxSub;
        }
    }
}

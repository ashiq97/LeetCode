using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class Binary_Search
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[6] { -1, 0, 3,5,9,12 };
        //    var target = 9;
          
        //    var result = Search(nums, target);


        //      Console.WriteLine($"resultt is {result}");
        //}
        public static int Search(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length -1;
            while(start <= end)
            {
                var mid = (start + end ) / 2;
                if (target == nums[mid])
                    return mid;
                else if (target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return -1;
        }
    }
}

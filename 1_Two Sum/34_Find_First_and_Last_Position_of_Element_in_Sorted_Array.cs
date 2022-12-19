using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _34_Find_First_and_Last_Position_of_Element_in_Sorted_Array
    {
        //public static void Main(string[] args)
        //{
        //   // var nums = new int[12] { 5, 7, 7, 8, 8,8,8,8,8, 11,11,14};
        //    var nums = new int[0] {};
        //    var target = 0;
        //    double start = target - .5;
        //    double end = target + .5;
        //    var result_start = BinarySearch(nums, start);
        //    var result_end = BinarySearch(nums, end);

        //    if(result_start != result_end)
        //        Console.WriteLine($"{result_start},{result_end-1}");
        //    else
        //    {
        //        Console.WriteLine($"{-1},{-1}");
        //    }
                

        //   // Console.WriteLine($"result is");
        //}
        public static int[] SearchRange(int[] nums, int target)
        {
            var start = 0;
            var end = nums.Length - 1;
            var firstPosition = 0;
            var lastPosition = 0;
            var flag = 0;

            while (start <= end)
            {
                var mid = start + (end - start) / 2;
                if (target == nums[mid])
                {
                    if (flag == 0)
                    {
                        firstPosition = mid;
                        flag = 1;
                    }
                    lastPosition = mid;
                    end = mid - 1;
                }
                else if (target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            if (firstPosition != 0 && lastPosition != 0)
                return new int[] { firstPosition, lastPosition };
            else
                return new int[] { -1, -1 };
        }
        public static int BinarySearch(int[] nums,double target)
        {
            var left = 0;
            var right = nums.Length - 1;
            while(left <= right)
            {
                var mid = left + (right - left) / 2;

                if ( target < nums[mid])
                    right = mid - 1;
                else if (target > nums[mid])
                    left = mid + 1;
            }
            return left;
        }
    }
}

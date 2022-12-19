using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _35_Search_Insert_Position
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[5] { 1, 3, 7, 16,25};
        //    var target = 30;

        //    var result = SearchInsert(nums, target);


        //    Console.WriteLine($"rest is {result}");
        //}
        public  static int SearchInsert(int[] nums, int target)
        {

            var start = 0;
            var end = nums.Length - 1;
            
            while(start <= end)
            {
                var mid = (start + end) / 2;

                if (target == nums[mid])
                    return mid;
                else if (target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            return start;
            // if number is not present in number list
            //start = 0;
            //end = nums.Length - 1;
            //while (start <= end)
            //{

            //    var mid = (start + end) / 2;

            //    //if (target > nums[mid])
            //    //    return mid;
            //    else if (target < nums[mid])
            //        end = mid - 1;
            //    else
            //        start = mid + 1;
            //}

        }
    }
}

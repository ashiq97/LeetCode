using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _128_Longest_Consecutive_Sequence
    {
        //static void Main(string[] args)
        //{
        //     //var inputNumber = new int[4] {1,2,0,1};
        //  //  var inputNumber = new int[10] {0,3,7,2,5,8,4,6,0,1};
        //    //var inputNumber = new int[7] {7,11,12,13,22,23,24};
        //   var inputNumber = new int[9] {11,12,7,22,28,24,25,26,27};
        //    //var inputNumber = new int[2] {0,0};
        //    var result = LongestConsecutive(inputNumber);
        //    Console.WriteLine($"result is  {result}");
        //}
        public static int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            // 1ST SORT THE ARREAY LIST
            Array.Sort(nums);

            // 2ND CALCULATE FOR SEQUENCE 
            int max = 0;
            int res = 0;
            int prev = nums[0];

            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i+1] - prev == 1)
                {
                    res = res + 1;
                    if (max < res)
                    {
                        max = res;
                    }
                }
                else
                { 
                    if (nums[i + 1] - prev != 0)
                        res = 0;
                }
                prev = nums[i+1];
            }
            
            max = max + 1;

            return max;
        }
    }
}

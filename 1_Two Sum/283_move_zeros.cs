using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public  class _283_move_zeros
    {
        //static void Main(string[] args)
        //{
        //   // var nums = new int[5] { 0,1,0,3,12};
        //    var nums = new int[3] { 0,0,1};

        //    MoveZeroes(nums);
        //}
        public static void MoveZeroes(int[] nums)
        {
            var left = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != 0)
                {
                    var temp = nums[i];
                    nums[i] = nums[left];
                    nums[left] = temp;
                    left = left + 1;
                }
            }
            var numbers = nums;
            Console.WriteLine();
        }
    }
}

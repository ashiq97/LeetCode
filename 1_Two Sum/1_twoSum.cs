using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public class _1_twoSum
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[] { 2, 7, 11, 15 };
        //    var target = 9;
        //    var result = TwoSum(nums, target);
        //    Console.WriteLine($"{result}");
        //}

        public static int[] TwoSum(int[] nums,int target)
        {
            Dictionary<int, int> dictio = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var res = target - nums[i];
                if(!dictio.ContainsKey(res))
                {
                    dictio[nums[i]] = i;
                }
                else
                {
                    return new int[] { dictio[res], i };
                }
            }


            throw new Exception("Not found");
        }
    }
}

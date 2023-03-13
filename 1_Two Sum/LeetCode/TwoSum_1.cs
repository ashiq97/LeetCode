using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode
{
    class TwoSum_1
    {
        static void Main(string[] args)
        {
            //var input1 = new int[4] {2,7,11,15 };
            //var target = 9;
            var input1 = new int[4] {2,1,5,3 };
            var target = 4;

            var res = TwoSum(input1, target);
            Console.WriteLine(res[0]);
            Console.WriteLine(res[1]);
            Console.ReadLine();
        }

        static int[] TwoSum(int[] nums, int target)
        {
            var dictio = new Dictionary<int, int>();
            int i;

            for (i = 0; i < nums.Length; i++)
            {
                var res = target - nums[i];
                 
                if (!dictio.ContainsKey(res))
                {
                    dictio.Add(nums[i],i);
                }
                else
                {
                    return new int[] { dictio[res], i };
                }
            }
            throw new Exception("Not Found");
        }
    }
}

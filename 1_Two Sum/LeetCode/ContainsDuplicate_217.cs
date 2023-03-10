using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode
{
    internal class ContainsDuplicate_217
    {
        static void Main(string[] args)
        {
            //var input = Console.ReadLine();
            
            var input = new int[4] {1,2,3,1};
           
            var res = ContainsDuplicate(input);
            Console.WriteLine(res);
            Console.ReadLine();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            var hasData = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hasData.ContainsKey(nums[i]))
                {
                    hasData[nums[i]] = nums[i];
                }
                else
                {
                    return true;
                }

            }
            return false;
        }
    }
}

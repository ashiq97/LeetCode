using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _217_Contains_Duplicate
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = new int[4] { 1,2,3,1};
        //    var result = ContainsDuplicate(input);
        //    Console.WriteLine($"Total {result}");
        //}
        public static bool ContainsDuplicate(int[] nums)
        {
            var hashTable = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!hashTable.Contains(nums[i]))
                    hashTable.Add(nums[i]);
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}

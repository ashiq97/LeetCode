using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _217_containsDuplocate
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[4] { 1, 2, 3, 4 };
        //    bool result = CheckAtleastTwice(nums);
        //    Console.WriteLine(result);
        //}

        public static bool CheckAtleastTwice(int[] nums)
        {
            var hashTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if(hashTable.ContainsKey(nums[i]))
                {
                    hashTable[nums[i]] += 1;
                    return true;
                }
                else
                {
                    hashTable[nums[i]] = 1;
                }
            }
            return false;
        }
    }
}

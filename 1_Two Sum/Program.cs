using System;
using System.Collections.Generic;

namespace _1_Two_Sum
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var listNode1 = new int[3] {2,4,3};
        //    var listNode2 = new int[3] {5,6,4};
        //    var result = AddTwoNumbers(listNode1, listNode2);
           

        //  //  Console.WriteLine($"[{result[0]},{result[1]}]");
        //}
        //public static int[] TwoSum(int[] nums, int target)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int j = i+1; j < nums.Length; j++)
        //        {
        //            if (nums[i] + nums[j] == target)
        //                return new int[] { i, j };
        //        }
        //    }
        //    throw new Exception("Not found");

        //}
        public static string AddTwoNumbers(int[] l1, int[] l2)
        {
            var re1 = reversenumber(l1);
            var re2 = reversenumber(l2);

            var res = re1.ToString() + re2.ToString();
            return "ss";
        }
        private static int[] reversenumber(int[] l1)
        {
            var ar = new int[l1.Length];
            var j = 0;
            for (int i = l1.Length-1; i >= 0; i--)
            {
                int rr = l1[i] % 10;
                ar[j] = rr;
                j++;
            }
            return ar;
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> hashTable = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = Math.Abs(target - nums[i]); // 
                
                if (hashTable.ContainsKey(complement))
                {
                    return new int[] { hashTable[complement], i };
                }
                else
                {
                    hashTable[nums[i]] = i;
                }
            }
            throw new Exception("Not found");

        }
    }
}

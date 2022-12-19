using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _2089_Find_Target_Indices_After_Sorting_Array
    {
        //static void Main(string[] args)
        //{
        //    var nums = new int[5] {1, 2,  5, 2, 3 };
        //    var target = 2;

        //    var result = SortArrayList(nums);
        //    var result2 = TargetIndices(nums, target);
            
        //    Console.WriteLine($"resultt is {result2}");
        //}

        public static int[] SortArrayList(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        var temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static IList<int> TargetIndices(int[] nums,int target)
        {
            List<int> store = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
               if(target == nums[i])
                    store.Add(i);
            }
            return store;
        }
    }
}

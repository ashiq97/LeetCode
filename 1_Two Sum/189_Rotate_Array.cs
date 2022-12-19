using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public class _189_Rotate_Array
    {

        //static void Main(string[] args)
        //{
        //    //var nums = new int[7] { 1,2,3,4,5,6,7};
        //    var nums = new int[3] { 1,2,3};
        //    //var nums = new int[1] {-1};
        //    var key = 4;
        //    nums = Rotate(nums,key);
        

        //    Console.WriteLine($"resultt is {nums}");
        //}

        public static int[] Rotate(int[] nums, int k)
        {
            var temp = new int[nums.Length];
            Array.Copy(nums, temp, nums.Length);


            if (k % nums.Length == 0 || nums.Length == 1)
                return nums;

            for (int i = 0; i < temp.Length; i++)
            {
               
                nums[(i+k)%nums.Length] = temp[i];
            }

            //while(iteration != k)
            //{
            //    for (int i = 0; i < temp.Length; i++)
            //    {
            //        if (index == temp.Length)
            //            index = 0;
            //        nums[index] = temp[i];
            //        index++;
            //    }
            //    Array.Copy(nums, temp, nums.Length);
            //    iteration++;
            //}

            return nums;

            //if (nums.Length == 1)
            //    return nums;

            //var n = temp.Length - k;
            //if (k > nums.Length)
            //    n = n * (-1); 

            //var index = 0;
            //for (int i = n; i < temp.Length; i++)
            //{
            //    if (index == k)
            //        break;
            //    nums[index] = temp[i];
            //    index++;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    nums[index] = temp[i];
            //    index++;
            //}
            //return nums;
            //var temp = new int[nums.Length];
            //var n = nums.Length - k;
            //var index = 0;
            //for (int i = n; i < nums.Length; i++)
            //{
            //    if (index == k)
            //        break;
            //    temp[index] = nums[i];
            //    index++;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    temp[index] = nums[i];
            //    index++;
            //}

            //nums = temp;
            //return nums;


        }

    }
}

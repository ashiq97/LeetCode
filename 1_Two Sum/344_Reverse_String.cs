using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public class _344_Reverse_String
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = "Let's take LeetCode contest";
        //    var splitedString = input.Split(' ');
        //    var iteration = 0;
        //    while (iteration != splitedString.Length)
        //    {
        //        var reverseWord = ReverseString(splitedString[iteration]);
        //        splitedString[iteration] = string.Concat(reverseWord);

        //        iteration++;
        //    }
        //    input = String.Join(" ",splitedString);
        //}
        public static char[]  ReverseString(string word)
        {
            var s = word.ToCharArray();
            var left_index = 0;
            var right_index = s.Length;
            for (int i = 0; i < s.Length; i++)
            {
                if (left_index >= right_index)
                    break;

                    var temp = s[left_index];
                    s[left_index] = s[right_index-1];
                    s[right_index-1] = temp;
                    
                    left_index ++;
                    right_index --;
            }
            return s;
        }
    }
}

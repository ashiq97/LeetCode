using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _3_Longest_Substring
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = "bbbbbbbb";
        //    Console.WriteLine(LengthOfLongestSubstring(input));

        //}
        public static int LengthOfLongestSubstring(string s)
        {
            var list = new List<char>();
            var max = 0;
            var a_index = 0;
            var b_index = 0;
            var i = 0;
             while(b_index<s.Length)
            { 
                if(!list.Contains(s[i]))
                {
                    list.Add(s[b_index]);
                    b_index++;

                    if (list.Count > max)
                        max = list.Count;
                }
                else
                {
                    list.Remove(s[a_index]);
                    a_index++;
                }
                i++;
            }
            return max;
        }
    }
}

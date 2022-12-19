using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _14_Longest_Common_Prefix
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var strs = new string[2] { "cir","car"};
        //   var result  =  LongestCommonPrefix(strs);
        //     Console.WriteLine($"Total {result}");
        //}
        public static string LongestCommonPrefix(string[] strs)
        {
            var list = new List<char>();
            if (strs.Length == 1)
            {
                var firstword = strs[0];
                for (int i = 0; i < strs[0].Length; i++)
                {
                    list.Add(firstword[i]);
                }
            }
            for (int i = 0; i < strs.Length - 1; i++)
            {
                var length = 0;
                if (strs[i].Length < strs[i + 1].Length)
                    length = strs[i].Length;
                else
                    length = strs[i + 1].Length;

                var firstword = strs[i];
                var secondword = strs[i+1];
                for (int j = 0; j < length; j++)
                {
                    //if (j == 0 && firstword[j] != secondword[j])
                    //    break;

                    if (firstword[j] == secondword[j] && !list.Contains(firstword[j]))
                        list.Add(firstword[j]);
                    else if (firstword[j] != secondword[j] && list.Contains(firstword[j]))
                        list.Remove(firstword[j]);
                }
            }
            string res = "";
            if(list.Count>0)
            {
                res = new string(list.ToArray());
            }

            return res;
        }
    }
}

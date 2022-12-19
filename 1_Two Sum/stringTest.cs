using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class stringTest
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = "rainforcears";
        //    CountCharachters(input);
        //   // Console.WriteLine($"Total {s}");
        //}
        private static void CountCharachters(string s)
        {
            var list = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if(!list.ContainsKey(s[i]))
                {
                    list.Add(s[i],1);
                }
                else
                {
                    list[s[i]] = list[s[i]] + 1;
                }

                
            }

            for (int i = 0; i < s.Length; i++)
            {
              Console.WriteLine($"{s[i] } comes {list[s[i]]} times");
            }


            
        }
    }
}

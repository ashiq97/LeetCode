using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode.NeetCode_1
{
    public class word_Pattern_290
    {
        static void Main(string[] args)
        {
            var pattern = "abba";
            var s = "dog dog dog dog";

            var res = MatchWordPattern(pattern, s);
            Console.WriteLine(res);
        }

        private static bool MatchWordPattern(string pattern,string s)
        {
            var hashTable = new Dictionary<char, string>();
            var flag = 0;

            if (pattern.Length != s.Split(' ').Length)
                return false;

            for(int i = 0;i<pattern.Length;i++)
            {
                if (!hashTable.ContainsKey(pattern[i]))
                {
                    if (hashTable.ContainsValue(s.Split(' ')[i]))
                        return false;
                    hashTable[pattern[i]] = s.Split(' ')[i];

                }
                else
                {
                    if (hashTable[pattern[i]] != s.Split(' ')[i])
                    {
                        flag = 1;
                        break;
                    }
                }
            }

            if (flag == 0)
                return true;
            
            return false;
        }
    }
}

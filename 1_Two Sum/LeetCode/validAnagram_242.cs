using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.LeetCode
{
    class validAnagram_242
    {
        //static void Main(string[] args)
        //{
        //    var input1 = "anagram";
        //    var input2 = "nagaram";

        //    var res = IsAnagram(input1, input2);
        //    Console.WriteLine(res);
        //    Console.ReadLine();
        //}
        public  static bool IsAnagram(string s, string t)
        {

            if (s.Length != t.Length)
                return false;

            var dic = new Dictionary<Char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dic.ContainsKey(s[i]))
                {
                    dic[s[i]] =  1;
                }
                else
                {
                    dic[s[i]] = dic[s[i]] + 1;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (dic.ContainsKey(t[i]))
                {
                    dic[t[i]] = dic[t[i]] - 1;

                    if (dic[t[i]] == 0)
                        dic.Remove(t[i]);
                }
                else
                {
                    return false;
                }
            }
            return dic.Count == 0;
        }
    }
}

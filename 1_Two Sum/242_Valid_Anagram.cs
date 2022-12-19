using System;
using System.Collections.Generic;
using System.Text;
namespace _1_Two_Sum
{
    class _242_Valid_Anagram
    {
        static void Main(string[] args)
        {
            // var nums = new int[5] { 0,1,0,3,12};
            var s = "aacc";
            var t = "caca";
            var result = IsAnagram(s, t);
            Console.WriteLine($"Total {result}");
        }
        public static bool IsAnagram(string s, string t)
        {

            //  solution 1

            //char[] ss = s.ToLower().ToCharArray();
            //char[] tt = t.ToLower().ToCharArray();

            //Array.Sort(ss);
            //Array.Sort(tt);
            //string NewWord1 = new string(ss);
            //string NewWord2 = new string(tt);
            //if(NewWord1== NewWord2)
            //{
            //    return true;
            //}else
            //{
            //    return false;
            //}


            // another solution 2

            
            Dictionary<char, int> hashTable = new Dictionary<char,int>();

            if (s.Length != t.Length)
                return false;

            for(int i = 0;i <s.Length;i++)
            {
                if(hashTable.ContainsKey(s[i]))
                {
                    hashTable[s[i]] = hashTable[s[i]] + 1;
                }
                else
                {
                    hashTable[s[i]] = 1;
                }
            }
            for (int i = 0; i < t.Length; i++)
            {
                if (hashTable.ContainsKey(t[i]))
                {
                    hashTable[t[i]] = hashTable[t[i]] - 1;

                    if (hashTable[t[i]] == 0)
                        hashTable.Remove(t[i]);
                } 
                else
                {
                    return false;
                }
            }

            return hashTable.Count == 0;
        }
    }
}

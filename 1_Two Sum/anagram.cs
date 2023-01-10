using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    internal class anagram
    {
        static void Main(string[] args)
        {
            var s = "aacc";
            var t = "acaac";
            var result = checkIsValidAnagram(s, t);
            Console.WriteLine(result);

        }

        private static bool checkIsValidAnagram(string s, string t)
        {
            var hashTable = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
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
                    {
                        hashTable.Remove(t[i]);
                    }
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

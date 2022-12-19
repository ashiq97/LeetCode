using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _392_Is_Subsequence
    {
        static void Main(string[] args)
        {
            var s = "abc";
            var t = "ahbgdc";
            var result = IsSubsequence(s,t);
            Console.WriteLine($"{result}");
        }
        public static bool IsSubsequence(string sequence, string testArray)
        {
            var seqIndx = 0;
            foreach (var item in testArray)
            {
                if (seqIndx == sequence.Length)
                    break;
                if (sequence[seqIndx] == item)
                    seqIndx++;
            }
            return seqIndx == sequence.Length; 
        }
    }
}

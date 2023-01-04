using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    public static class ExtensionMethod
    {
        //static void Main(string[] args)
        //{
        //    var input = "rainforcears";
        //    var ss = input.Reverse();
        //    Console.WriteLine(ss);
        //}
        public static string Reverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

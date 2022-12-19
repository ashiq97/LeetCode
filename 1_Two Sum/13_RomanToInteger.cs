using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class _13_RomanToInteger
    {
        //static void Main(string[] args)
        //{
        //    // var nums = new int[5] { 0,1,0,3,12};
        //    var input = "MCMXCIV";
        //    var s = RomanToInt(input);
        //    Console.WriteLine($"Total {s}");
        //}
        public static int RomanToInt(string s)
        {
            var romanValues = new Dictionary<char, int>();
            romanValues.Add('I', 1);
            romanValues.Add('V', 5);
            romanValues.Add('X', 10);
            romanValues.Add('L', 50);
            romanValues.Add('C', 100);
            romanValues.Add('D', 500);
            romanValues.Add('M', 1000);

            var total = 0;
            var previous = 'y';

            for (int i = 0; i < s.Length; i++)
            { 
                total += romanValues[s[i]];
                
                if(previous!='y')
                {
                    if (previous == 'I' && (s[i] == 'V' || s[i] == 'X'))
                    {
                        total = total - 2* romanValues[previous];
                    }
                    else if (previous == 'X' && (s[i] == 'L' || s[i] == 'C'))
                    {
                        total = total - 2 * romanValues[previous];
                    }
                    else if (previous == 'C' && (s[i] == 'D' || s[i] == 'M'))
                    {
                        total = total - 2 * romanValues[previous];
                    }
                }

                previous = s[i];
            }
            return total;
        }
    }
}

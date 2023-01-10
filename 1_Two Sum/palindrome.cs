using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    internal class palindrome
    {
        //static void Main(string[] args)
        //{
        //    var result = CheckPalindrome(1221);
        //    Console.WriteLine(result);
        //    var strResult = CheckStringPlindrome("abbcbba");
        //    Console.WriteLine(strResult);

        //}

        private static bool CheckStringPlindrome(string str)
        {
            var strLength = str.Length;
            var isPlaindrome = true;

            for (int i = 0; i < strLength/2; i++)
            {
                if (str[i] != str[strLength - i-1])
                {
                    isPlaindrome= false;
                    break;
                }    
            }

            return isPlaindrome;

        }

        private static bool CheckPalindrome(int n)
        {
            var originalNumber = n;
            var reversed = 0;
            while(n> 0)
            {
                var lastDigit=n%10;
                reversed = reversed * 10 + lastDigit;
                n = n/ 10;
            }

            if(originalNumber == reversed)
                return true;
            else
                return false;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    static class reverseString
    {
        public static void Main(string[] args)
        {
            var name = "hello";
            var result = Reverse(name);
            Console.WriteLine(string.Concat(result));
            var resultEx = name.DoReverse();
            Console.WriteLine(resultEx);

            var text = "Let's take LeetCode contest";
            var newText = text.Split(' ');
            for (int i = 0; i < newText.Length; i++)
            {
                var reverseWord = newText[i].DoReverse();
                    newText[i] = reverseWord;
            }

            text = string.Join(' ', newText);

            Console.WriteLine(text);

        }

        public static Char[] Reverse(string name)
        {
            var nameArr = name.ToCharArray();
            var left_index = 0;
            var right_index = nameArr.Length-1;

            while(left_index <= right_index)
            {

                var t = nameArr[left_index];
                nameArr[left_index] = nameArr[right_index];
                nameArr[right_index] = t;

                left_index++;
                right_index--;
            }

            return nameArr;
        }
        public static string DoReverse(this string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}

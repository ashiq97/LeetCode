using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    internal class FizzBuzz
    {
        //static void Main(string[] args)
        //{
        //    var result = GetFizzBuzz();
        //    foreach (var item in result)
        //    {
        //        Console.WriteLine(item);
        //    }
           
        //}

        private static List<string> GetFizzBuzz()
        {
            List<string> list = new List<string>();

            for (int i = 0; i <= 15; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                    list.Add("FizzBuzz");
                else if (i % 3 == 0)
                    list.Add("Fizz");
                else if (i % 5 == 0)
                    list.Add("Buzz");
                else
                    list.Add(i.ToString());
            }
            return list;
        }
    }
}

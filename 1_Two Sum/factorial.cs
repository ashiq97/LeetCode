using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum
{
    class factorial
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Enter a Number");
        //    var num = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Factorial of {0} is {1}", num, Factorial(num));
        //}

        public static int Factorial(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * Factorial(num - 1);
        }
    }
}

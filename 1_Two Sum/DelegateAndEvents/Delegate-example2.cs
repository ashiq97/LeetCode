using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.DelegateAndEvents
{
    public  class Delegate_example2
    {
        delegate int ourDelegate(int x);
        //static void Main(string[] args)
        //{
        //    Test();
        //    Console.ReadLine();
        //}

        public static void Test()
        {
            ourDelegate del = Add;
            var addition = del(20);

            Console.WriteLine(addition);

            del = mul;
            var multiplication = del(30);

            Console.WriteLine(multiplication);
        }

        static int Add(int x)
        {
            return x + x;
        }
        static int mul(int x)
        {
            return x * x;
        }

    }
}

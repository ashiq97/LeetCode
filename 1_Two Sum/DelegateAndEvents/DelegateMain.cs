using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.DelegateAndEvents
{
    internal class DelegateMain
    {
        public delegate int myDelegate(int x, int y);
        static void Main(string[] args)
        {
            delegateSum delSum = new delegateSum();

            myDelegate myDel = delSum.Add;
            var result = myDel(100, 200);
            Console.WriteLine(result);

            myDel = delSum.Multiply;
            result = myDel(100, 200);
            Console.WriteLine(result);
        }

        public static void TestPrinter(string msg,double value)
        {
            System.Console.WriteLine("Hello from "+msg + value);
        }
    }
}

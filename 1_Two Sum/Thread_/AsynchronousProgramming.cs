using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _1_Two_Sum.Thread_
{
    internal class AsynchronousProgramming
    {
        static void Main(string[] args)
        {
            Test();
            Console.ReadLine();
        }

        public static void Test()
        {
            Calculate();
        }
        public static async void Calculate()
        {
            // case 1: Synccronous operation

            //Calculate1();
            //Calculate2();
            //Calculate3();

            // case 2: asyncronous operation
            //Task.Run(() =>
            //{
            //    Calculate1();
            //});

            //Task.Run(() =>
            //{
            //    Calculate2();
            //});

            //Task.Run(() =>
            //{
            //    Calculate3();
            //});

            // case 3: before Task 3 need to finish task 1 and task 2

            //var task1 = Task.Run(() =>
            //{
            //    Calculate1();
            //});

            //var task2 = Task.Run(() =>
            //{
            //    Calculate2();
            //});

            //Task.WaitAll(task1, task2);

            //var task3 = Task.Run(() =>
            //{
            //    Calculate3();
            //});

            //  case 4: before Task 3 need to get result of  task 1 and task 2

            //var task1 = Task.Run(() => Calculate1());

            //var task2 = Task.Run(() => Calculate2());

            //Task.WaitAll(task1, task2);

            //var r1 = task1.GetAwaiter().GetResult();
            //var r2 = task2.GetAwaiter().GetResult();

            //Calculate3(r1, r2);


            //  case 5: using async await->  before Task 3 need to get result of  task 1 and task 2
            // output Result 1
            //        Result 200
            //        Result 2

            await Calculate1_2();
            Calculate2();

        }

        async static Task Calculate1_2()
        {
            var result = await Task.Run(() => Calculate1());
            Calculate3(result, result);
        }

        static int Calculate1()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Result 1");
            return 100;
        }

        static int Calculate2()
        {
            Console.WriteLine("Result 2");
            return 200;
        }

        static void Calculate3(int r1,int r2)
        {
            var res = r1+r2;
            Console.WriteLine($"Result {res}");
            //return 300;
        }
    }
}

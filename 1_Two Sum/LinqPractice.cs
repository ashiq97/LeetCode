using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Two_Sum
{
    class LinqPractice
    {
        //static void Main(string[] args)
        //{
        //    //1.How would you use LINQ to query a list of integers and return the odd numbers?
        //    List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        //    var oddNumbers = numbers.Where(x => x % 2 != 0);
        //    //ShowResult(oddNumbers);

        //    //2.How would you use LINQ to query a list of strings and return the ones that have a length greater than 5 characters ?
        //    var words = new List<string> { "cat", "dog", "tiger", "Elephent", "Lion" };
        //    var longWords = words.Where(w => w.Length > 5);
        //    ShowResult(longWords);

        //    //3 Can you provide an example of how to use the "GroupBy" LINQ method?
        //    var groupedWords = words.GroupBy(x => x.Length);

        //    foreach (var item in groupedWords)
        //    {
        //        Console.WriteLine(item.Key);
        //    }
            
        //    //4.How would you use LINQ to query a list of custom objects and return the ones that have a specific property value?
        //    //5.How would you use LINQ to query a list of integers and return the sum of all the even numbers?



        //}

        static void ShowResult(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        
    }
}

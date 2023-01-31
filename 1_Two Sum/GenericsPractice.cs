using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_Two_Sum
{
    public class GenericsPractice
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> myGenericClass = new MyGenericClass<int>();
            myGenericClass.MyProperty = 29;
            NonGeneric nonGeneric = new NonGeneric();
            string t = "20";
            nonGeneric.value = t;
            nonGeneric.show();


            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(x => x % 2 == 0);
            foreach (var item in evenNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class MyGenericClass<T>
    {
        public T MyProperty { get; set; }
    }


    public class NonGeneric
    {
        public object value { get; set; }
        public void show()
        {
            Console.WriteLine(value);
        }
    }
}

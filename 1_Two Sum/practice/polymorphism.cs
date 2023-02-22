using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.practice
{
    public class Vehicle
    {
        public virtual void move()
        {
            Console.WriteLine("vehicle should move");
        }
    }

    class Car : Vehicle,IExample
    {
        public override void move()
        {
            Console.WriteLine("car should move");
        }

        public void sum()
        {
            throw new NotImplementedException();
        }
    }
    interface IExample
    {
        void sum();
    }
    class polymorphism
    {
        //public static void Main (string[] args)
        //{
        //    Vehicle vehicle = new Car();

        //    vehicle.move();

        //    vehicle = new Vehicle();
        //    vehicle.move();
        //}
    }

}

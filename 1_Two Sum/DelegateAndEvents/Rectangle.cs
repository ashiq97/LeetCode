using System;
using System.Collections.Generic;
using System.Text;

namespace _1_Two_Sum.DelegateAndEvents
{
    internal class Rectangle
    {
        public delegate void Print(string msg, double value);
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }


        public void PrintArea(string msg,Action<string,double> printer)
        {
            printer(msg,CalculateArea());
        
        }
    }
}

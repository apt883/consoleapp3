using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Shape
    {
        protected double length;
        protected double width;
    }
    public class Square : Shape
    {
        public Square(double side)
        {
            length = width = side;
        }
        public void PrintArea()
        {
            Console.WriteLine("Area of square is " + (length * width));
        }
    }
    public class Rectangle : Shape
    {
        public Rectangle(double l,double w)
        {
            length = l;
            width = w;
        }
        public void PrintArea()
        {
            Console.WriteLine("Area of rectangle is " + (length * width));
        }
    }
    class Class1
    {
        static void Main2(string[] args)
        {
            Rectangle r = new Rectangle(3.5, 6.9);
            r.PrintArea();
            Square s = new Square(5.2);
            s.PrintArea();
        }
    }
}

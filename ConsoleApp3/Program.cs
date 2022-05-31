using System;

namespace ConsoleApp3
{  
    //properties
    class PropertiesInClass
    {
        public PropertiesInClass(double r)
        {
            _radius = r;
        }
        private double _radius;
        private double _pi = 3.14;
        public double radius
        {
            get
            {
                return _radius;
            }
        }
        public void PrintCircumference()
        {
            Console.WriteLine(2 * _pi * radius);
        }
    }

    class Program
    {
        static void Main1(string[] args)
        {
            PropertiesInClass p = new PropertiesInClass(2.5);
            Console.WriteLine("Radius is " + p.radius);
            p.PrintCircumference();
            Console.ReadLine();
        }
    }
}

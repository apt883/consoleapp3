using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Classc
    {
        public static void sum()
        {
            int sum = 2 + 5;
            Console.WriteLine(sum);
        }
        public static void sum(int a,int b)
        {
           int sum = a + b;
            Console.WriteLine(sum);

        }
        public static void sum(int a,int b,int c)
        {
            int sum = a + b + c;
            Console.WriteLine(sum);
        }
        public static void sum(string a,string b)
        {
            int sum = Convert.ToInt32(a) + Convert.ToInt32(b);
            Console.WriteLine(sum);
        }
        static void Main5(string[] args)
        {
            sum();
            sum(1, 2, 3);
            sum(5, 6);
            sum("1", "2");
            Console.ReadLine();
        }
    }
    class Class4
    {
        static void Main2(string[] args)
        {
          
        }
    }
}

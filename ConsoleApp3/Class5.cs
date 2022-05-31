using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Calculator
    {
        public int Number1, Number2;
        public Calculator(int Num1, int Num2)
        {
            Number1 = Num1;
            Number2 = Num2;
        }
        public void Print()
        {
            Console.WriteLine("Number 1=" + Number1);
            Console.WriteLine("Number 2=" + Number2);
        }
        public static Calculator operator *(Calculator c1, Calculator c2)
        {
            Calculator c3 = new Calculator(1, 1);
            c3.Number1 = c1.Number1 * c2.Number1;
            c3.Number2 = c1.Number2 * c2.Number2;
            return c3;
        }
    }
    class Class5
    {
        static void Main6(string[] args)
        {
            Calculator calculator1 = new Calculator(9, 8);
            Calculator calculator2 = new Calculator(10, 7);
            Calculator calculator3 = new Calculator(1, 1);
            calculator3 = calculator1 * calculator2;
            calculator3.Print();
            Console.ReadLine();
        }
    }
}

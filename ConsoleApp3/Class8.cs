using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Hello! My Name is " + Name;
        }
    }
    class Class8
    {
        static void Main8(string[] args)
        {
            int total = 3;
            person[] persons = new person[total];
            for (int i = 0; i < total; i++)
            {
                persons[i] = new person()
                { Name = Console.ReadLine() };
            }
            for(int i=0;i<total;i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Abstractclass
    {
        public abstract class Animal
        {
            private string Name;
            public void SetName(string name)
            {
                Name = name;

            }
            public string GetName()
            {
                return Name;
            }
            public abstract void Eat();
        }
        public class Dog:Animal
        {
            public override void Eat()
            {
                Console.WriteLine("Eating");
            }
        }
        static void Main7(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine("Enter Dog name..");
            dog.SetName(Console.ReadLine());
            Console.WriteLine(dog.GetName());
            dog.Eat();
        }
    }
}

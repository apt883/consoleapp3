using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
   public class Person
    {
        public void Greet()
        {
            Console.WriteLine("hello..");
        }
        protected int age;
        public void SetAge(int n)
        {
            age = n;
        }

    }
    public class Student:Person
    {
        public void Study()
        {
            Console.WriteLine("I am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine("my age is{0} years old",age);
        }
    }
    public class Teacher : Person
    {
        public void Explain()
        {
            Console.WriteLine("i am explainig");
        }
    }
   public class StudentTeacherTest
    {
        static void Main3(string[] args)
        {
            Person myPerson = new Person();
            myPerson.Greet();
            Student myStudent = new Student();
            myStudent.SetAge(20);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();
            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(31);
            myTeacher.Greet();
            myTeacher.Explain();
                Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Baseclass
    {
        public virtual void Show()
        {
            Console.WriteLine("I am coming from base class..");
        }

    }
    class Derivedclass:Baseclass
    {
        public override void Show()
        {
            Console.WriteLine("I am coming from derived class..");
        }
    }
    class Class6
    {
        static void Main7(string[] args)
        {
            Derivedclass d = new Derivedclass();
            d.Show();

            Baseclass Obj;
            Obj = new Baseclass();
            Obj.Show();

            Obj = new Derivedclass();
            Obj.Show();
            Console.ReadLine();
        }
    }
}

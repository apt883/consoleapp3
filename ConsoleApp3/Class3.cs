using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Photobook
    {
        protected int numPages;
        public Photobook()
        {
            numPages = 16;
        }
        public Photobook(int numPages) 
        {
            this.numPages = numPages;
        }
        public int GetNumberPages()
        {
            return numPages;
        }
    }
    public class BigPhotoBook : Photobook
    {
        public BigPhotoBook()
        {
            numPages = 64;
        }
    }
    class PhotoBookTest
    {
        static void Main4(string[] args)
        {
            Photobook Album1 = new Photobook();
            Console.WriteLine(Album1.GetNumberPages());
            Photobook Album2 = new Photobook(24);
            Console.WriteLine(Album2.GetNumberPages());
            BigPhotoBook Alb1 = new BigPhotoBook();
            Console.WriteLine(Alb1.GetNumberPages());
            Console.ReadLine();

        }
    }
}

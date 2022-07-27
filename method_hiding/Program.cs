using System;

namespace method_hiding
{
    class Dummy
    {
        public void Show()
        {
            Console.WriteLine("this is parent class method");
        }
    }

    class demo : Dummy
    {
        public   new void Show()
        {
            Console.WriteLine("this is child class method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo D = new demo();
            D.Show();
            Console.ReadLine();
        }
    }
}

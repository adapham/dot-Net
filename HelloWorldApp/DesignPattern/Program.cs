using System;

namespace DesignPattern
{
    internal class Program
    {
        class Singleon
        {
            static readonly Singleon Insstance;
            static int total = 0;
            static Singleon()// thiet lap cho bien static
            {
                Insstance = new Singleon();
                total++;
            }
            public static Singleon GetInsstance() => Insstance;
            public static int Total => total;
        }
        static void Main(string[] args)
        {
            Singleon s = Singleon.GetInsstance();
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Total:{Singleon.Total}");

        }
    }
}

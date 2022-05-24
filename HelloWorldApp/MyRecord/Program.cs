using System;

namespace MyRecord
{
    record Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Age = 20, Name = "A" };
            Person person1 = new Person { Age = 20, Name = "A" };
            Console.WriteLine($"p=p1{person1==person}");
            Console.ReadLine();
        }
    }
}

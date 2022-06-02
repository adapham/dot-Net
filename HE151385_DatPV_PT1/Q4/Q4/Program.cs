using System;
using System.Collections;
using System.Collections.Generic;

namespace Q4
{
    public class Program
    {
        class Person
        {
            int Age;
            string Name;

            public Person()
            {

            }
            public Person(int age, string name)
            {
                this.Age1 = age;
                this.Name1 = name;
            }

            public int Age1 { get => Age; set => Age = value; }
            public string Name1 { get => Name; set => Name = value; }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }
        class MyCollection<T> : IEnumerable where T : class, new()
        {
            private List<T> list = new List<T>();
            public void AddItems(params T[] items) => list.AddRange(items);
            IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();
        }


        static void Main(string[] args)
        {
            Person p1 = new Person(18, "A");
            Person p2 = new Person(18, "B");
            Person p3 = new Person(18, "C");
            Person p4 = new Person(18, "D");

            MyCollection<Person> myCollection = new MyCollection<Person>();
            myCollection.AddItems(p1, p2, p3, p4);

            Console.WriteLine("OUTPUT:");
            foreach (Person p in myCollection)
                Console.WriteLine(p);

            Console.ReadLine();
        }

    }
}
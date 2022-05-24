using System;
using System.Collections;
using System.Collections.Generic;

namespace MyIEnumerable
{
    class MyConlecttion<T> :IEnumerable where T : class
    {
        ArrayList list= new ArrayList();
        public void AddItem(params T[] items) => list.AddRange(items);

        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)list).GetEnumerator();
        }

        public T GetItem(int pos) => list[pos];
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"id={Id} name={Name}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();//
            al.Add(10);
            al.Add(new Student {Id=1,Name="a"});
            foreach (dynamic s in al)
            {
                Console.WriteLine(s);
            }
            List<Student> list = new List<Student>();
            //list.Add(1);//
            list.Add(new Student{Id=2,Name="b"});
            foreach (var s in al) /// vvar laf kieu khong thay doi
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Hello World!");
            MyConlecttion<Student> m = new MyConlecttion<Student>();
            Student[] ls = new Student[2];
            ls[0] = new Student { Id = 3, Name = "ljo" };
            ls[1] = new Student { Id = 3, Name = "ljo1" };
            m.AddItem(ls);
            foreach (var s in m)
            {
                Console.WriteLine(s);
            }
        }
    }
}

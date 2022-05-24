using System;

namespace OPP
{
    //Encapsulation
    //Inhereitance
    //Polymorphism
    // class: kiểu dũ liệu mà user đặt 
    // internal, public:type(car) or type member(tring name) 
    // private: protected
    //UML ngon ngu thong nhat
    //virtual: co the averride
    //abstract, override , : must overide , new thi phai ep kieu
    //

    internal class Program
    {
        //default internal- tat
        class Student
        {
            //default private: 
            //data field 
            int age;
            string name;

            public Student(int age, string name)
            {
                this.age = age;
                this.name = name;
            }

            public int Age { get => age; set => age = value; }
            public string Name { get => name; set => name = value; }

            public override string ToString()
            {
                return $"nam:{name} age:{age}";
            }
        }
        class Gradua : Student
        {
            int mark;

            public Gradua(int age, string name, int mark) : base(age, name)
            {
                this.mark = mark;
            }
        }
        abstract class Shape
            {
            public abstract void Draw();
            }
        class Circle : Shape
        {
            public override void Draw()
            {
                
            }
        }
        class Circle3D : Shape
        {
            public override void Draw()
            {
                
            }
        }

        static void Main(string[] args)
        {
            Student student = new Student(20,"a");

            Console.WriteLine(student);

        }

    }
}

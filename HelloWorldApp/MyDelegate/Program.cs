using System;

namespace MyDelegate
{
    //public delegate void Mess(string message);
    class Car
    {
        // Func là phải có kiểu trả về
        // Func<int, int> f2; //delegate int f2(int);
        // Action Func - generic
        //Action action; // ~ delegate void Kieu();
        //Action<string, string> action1; // ~ delegate void Kieu(string s, string i);
        public event Action<string> HightSpeed; //~ delegate void
        public string Brand { get; set; }
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public void Accelerate(int delta)
        {
            if (CurrentSpeed <= MaxSpeed)
            {
                CurrentSpeed += delta;

            }else HightSpeed($"Can't speed up!");
        }
    }
    //class Utility
    //{
    //    public int Add(int a, int b) => a + b;
    //    public int Sub(int a, int b) => a - b;
    //    public void Print(string mess) => Console.WriteLine(mess.ToLower());
    //    public void Display(string mess) => Console.WriteLine(mess);
    //}
    internal class Program
    {
        //publisher -> class phat su kien
        //subcriber -> class nhan su kien
        //private static void Car_HightSpeed(string arg)
        //       => Console.WriteLine(arg);
        static void Main(string[] args)
        {
            
            //Utility utility = new Utility();
            //MyDelegate myDelegate = utility.Add;
            //int a = 10;
            //int b = 10;
            //Console.WriteLine($"{a}+{b}={myDelegate(a,b)}");
            //Func<int, int, int> func = utility.Sub;
            //Console.WriteLine($"{a}+{b}={func(a, b)}");
            //Console.WriteLine("Hello World!");
            //Action<string> action = utility.Print;
            //action += utility.Display;
            //action += utility.Print;
            //action("FJSLD");
            //================================

            Car car = new Car { Brand = "Fort", CurrentSpeed = 50, MaxSpeed = 200 };
            car.HightSpeed += Car_HightSpeed;

            for (int i = 0; i < 10; i++)
            {
                car.Accelerate(20);
               
            }

        }

        private static void Car_HightSpeed(string obj)
        {
            throw new NotImplementedException();
        }
    }
 }


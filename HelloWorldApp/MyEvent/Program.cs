using System;
using System.Collections.Generic;

namespace MyEvent
{
    class Student {
        public event Action<string, double> lowMark;
        public string Name { get; set; }
        public double Mark { get; set; }
        public void CheckMark()
        {
            if (Mark < 4) lowMark(Name,Mark);
        }
    
    }
    
    class Account
    {
        public event Action<int, int> SetAccountNumber;
        int accountNumber;
        double balance;

        public int AccountNumber { get => accountNumber;
            set {
                SetAccountNumber(accountNumber,value);
                accountNumber =value;

            }
            }
        public double Balance { get => balance; set => balance = value; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Account account = new Account();
            account.SetAccountNumber += Account_SetAccountNumber;
            account.AccountNumber = 110;
            account.AccountNumber = 1100;
            Console.WriteLine("Hello World!");
            List<Student> list = new List<Student>
        {
            new Student { Name ="A", Mark=5},
            new Student { Name="B", Mark=6},
            new Student{ Name="C", Mark=2},
            new Student{ Name ="D", Mark=8}
        };
            
           //foreach(var student in list)
           // {
           //     student.lowMark += Student_lowMark;
           //     student.CheckMark();
           // }
            int n = 0;
            Console.WriteLine("Nhap so luong pt:");
            n = int.Parse(Console.ReadLine());
            string[] Tteam = new string[n];
            Console.WriteLine($"Nhap so luong {Tteam.Length}");

        }

        private static void Student_lowMark(string arg1, double arg2)
        {
            Console.WriteLine($"Danh sach HS: Name: {arg1}, Mark: {arg2}");
        }

        private static void Account_SetAccountNumber(int arg1, int arg2)
        {
            Console.WriteLine($"old {arg1}, new {arg2}");
        }
    }
}

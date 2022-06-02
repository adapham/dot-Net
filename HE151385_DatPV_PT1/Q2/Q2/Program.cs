using System;
using System.Text.RegularExpressions;

namespace Q2
{
    interface IUtility
    {
        string GetString(string msg, string pattern);
    }

    class Utility : IUtility
    {
        public string GetString(string msg, string pattern)
        {
            string value = "";
            do
            {
                Console.Write(msg);
                value = Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(value)) break;

            } while (true);
            return value;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Utility u = new Utility();
            string id;
            string name;
            id = u.GetString("Enter ID (HE123456):", "^[H][E][0-6]{6}$");
            name = u.GetString("Enter name (NOT EMPTY):", "^[A-Za-z]{1}[a-zA-Z]*");
            Console.WriteLine("OUTPUT");
            Console.WriteLine($"ID = {id}");
            Console.WriteLine($"Name = {name}");
            Console.ReadLine();
        }

    }
}
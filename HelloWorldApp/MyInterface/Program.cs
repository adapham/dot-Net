using System;
using System.Text.RegularExpressions;

namespace MyInterface
{
    interface IUtility
    {
        double GetDouble(string mess, double min, double max);
          string GetString(string mess, string pattern);
    }
    class Utility : IUtility
    {
        double IUtility.GetDouble(string mess, double min, double max)
        {
            double temp = 0.0; ;
            do
            {
                 Console.WriteLine(mess);
                string value = Console.ReadLine();
                if (double.TryParse(value, out temp))//
                {
                    if (temp <= max && temp >= min)
                     {
                           break;
                     }
                }
                else
                {
                    Console.WriteLine("Error");
                }
            } while (true) ;
            return temp;

        }

        string IUtility.GetString(string mess, string pattern)
        {
            string value = "";
            do
            {
                Console.Write(mess);
                value= Console.ReadLine();
                Regex regex = new Regex(pattern);
                if (regex.IsMatch(value)) break;
            }while (true);

            return value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string id;
            double money;
                Utility u = new Utility();
                //id = (u as IUtility).GetString("Enter student id(HE15)","^[H][E][0-9]{2}$");
            money = (u as IUtility).GetDouble("Nhap so trong khoảng : ", 1, 9);
            Console.WriteLine(money);
        }

    }
}

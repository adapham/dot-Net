using System;

namespace Q1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            float marks;
            Utility u = new Utility();
            marks = u.GetFloat("Enter marks (0-10):", 0, 10);
            Console.WriteLine("OUTPUT");
            Console.WriteLine($"Marks = {marks}");
            Console.ReadLine();
        }

    }
    interface IUtility
    {
        float GetFloat(string mess, float min, float max);
       
    }

    internal class Utility : IUtility

    {
        public float GetFloat(string mess, float min, float max)
        {
            var value = 0.0f;
            do { 
            Console.WriteLine(mess);
            string value1 = Console.ReadLine();
            if (float.TryParse(value1, out value))//
            {
                if ( value<= max && value >= min)
                {
                    break;
                }
            }
        } while (true) ;
            return value;
        }
    }

}

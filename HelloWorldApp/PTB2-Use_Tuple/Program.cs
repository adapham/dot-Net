using System;

namespace PTB2_Use_Tuple
{
    internal class Program
    {
        
        static (double? x1,double? x2) MyPtB2(double a,double b,double c)
        {   
            var r = (x1: 0.0, x2: 0.0;
            double delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                return r;
            }
            else if (delta == 0)
            {
                r.x1  = -b / (2 * a);
                r.x2 = null;
                return r;
            }
            else
            {
                delta = Math.Sqrt(delta);
                r.x1 = (-b + delta) / (2 * a);
                r.x2 = (-b - delta) / (2 * a);
                return r;
            }
            
        } 
        static void Main(string[] args)
        {
            var (x1, x2) = MyPtB2(1, 9, 3);
            
            Console.WriteLine(MyPtB2(1, 9, 3));
            Console.ReadLine();
        }
    }
}

using System;
using System.IO;
using System.Threading;
namespace IOBacHoImage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (string line in System.IO.File.ReadLines(@"D:\BacHo.txt"))
            {
                Thread.Sleep(500);
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }
       
    }
}

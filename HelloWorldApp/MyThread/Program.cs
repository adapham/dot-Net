using System;
using System.Threading;

namespace MyThread
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 5; i++)
            {
                var temp = i;
                Thread t = new Thread(() =>
                {
                    DemoThread("Thead" + temp);

                });
                t.Start();

                //Thread t = new Thread(() => { DemoThread("Thead 1 : ");

                //});
                //Thread t2 = new Thread(() => {
                //    DemoThread("Thead 2 : ");
                //});
                //t.Start();

            }
            static void DemoThread(string mess)
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine(mess + " " + i);
                }
            }
        }
    }
}

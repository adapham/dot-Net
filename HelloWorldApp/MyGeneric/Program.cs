using System;

namespace MyGeneric
{
    internal class Program
    {
        // List<T> khi dung moi khai bao
        // an toan ve kieu, ko nhay tu heap sang vung nho lung tung
        // Class: kkhi muon gop cac kieu khac nhau
        // 
        static void swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a; a = b; b = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            string s1, s2;
            a = 10;
            b = 20;
            s1="hello";
            s2="Wellcome";
            swap<int>(ref a, ref b);
            Console.WriteLine($"a={a}b={b}");
            swap<string>(ref s1, ref s2);
            Console.WriteLine($"s1={s1} s2={s2}");
            Console.WriteLine("Hello World!");
        }
    }
}

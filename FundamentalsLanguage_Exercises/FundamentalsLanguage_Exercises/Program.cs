using System;

namespace FundamentalsLanguage_Exercises
{
    internal class Program
    {
        //  word reverse 
        static void wreverse()
        {
            int temp;
            string s = Console.ReadLine();
            string[] a = s.Split(' ');
            int k = a.Length - 1;
            temp = k;
            for (int i = k; temp >= 0; k--)
            {
                Console.Write(a[temp] + "" + ' ');
                --temp;
            }
            Console.ReadKey();
        }
        //SwitchFirstLastLetter
        static string SwitchFirstLastLetter(string word)
        {
            int wordLength = word.Length;
            char firstLetter = word[0];
            char lastLetter = word[wordLength - 1];
            char[] wordChars = word.ToCharArray();

            wordChars[0] = lastLetter;
            wordChars[wordLength - 1] = firstLetter;
       
            return new string(wordChars);
        }
        static string ReverseStringWords(string text)
        {
            string[] words = text.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }
        static void Sumofthedigits()
        {
            var temp = 0;
            string numbers;
            do
            {
                Console.Write("Input a number(integer): ");
                 numbers = Console.ReadLine();
                if (int.TryParse(numbers, out temp))
                {
                    temp = int.Parse(numbers);
                }
                else
                {
                    Console.WriteLine("Error, Input again:");
                }
            }
            while(temp==0);
            int total = 0;
            foreach (char number in numbers)
            {
                total += int.Parse(number.ToString());
            }
            Console.WriteLine($"Sum of the digits of the {numbers} integer: {total}");
        }

        static void Main(string[] args)
        {
            //wreverse();
            Sumofthedigits();
        }
    }
}

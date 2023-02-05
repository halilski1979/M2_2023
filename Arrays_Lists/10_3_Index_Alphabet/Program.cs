using System;

namespace _10_3_Index_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine($"{word[i]} -> {(int)word[i]-97}");
            }
        }
    }
}

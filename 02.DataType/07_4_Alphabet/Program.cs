using System;

namespace _07_4_Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        char l1 = (char)('a' + i);
                        char l2 = (char)('a' + j);
                        char l3 = (char)('a' + k);
                        Console.WriteLine($"{l1}{l2}{l3}");
                    }
                }
            }
        }
    }
}

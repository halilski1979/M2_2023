using System;

namespace _07_2_SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());                    

            for (int i = 1; i <= n; i++)
            {
                int sumChislo = 0;
                int chislo = i;
                while (chislo > 0)
                {
                    sumChislo += chislo % 10;
                    chislo /= 10;
                }

                if (sumChislo==5 || sumChislo==7 ||sumChislo==11)
                {
                    Console.WriteLine($"{i} => True");
                }
                else
                {
                    Console.WriteLine($"{i} => False");
                }

            }
            
            
        }
    }
}

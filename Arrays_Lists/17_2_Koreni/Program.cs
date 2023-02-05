using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_2_Koreni
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var koren = new List<int>();

            for (int i = 0; i < num.Count; i++)
            {
                if (Math.Sqrt(num[i])==(int)Math.Sqrt(num[i]))
                {
                    koren.Add(num[i]);
                }
            }

            koren.Sort();
            koren.Reverse();

            Console.WriteLine(string.Join(" ",koren));

        }
    }
}

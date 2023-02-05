using System;
using System.Linq;

namespace _10_1_Statistika_2Nachin
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            int s=0, min=int.MaxValue, max=int.MinValue;

            for (int i = 0; i < num.Length; i++)
            {
                s += num[i];
                if (num[i]<min)
                {
                    min = num[i];
                }
                if (num[i]>max)
                {
                    max = num[i];
                }
            }

            Console.WriteLine($"Min={min}");
            Console.WriteLine($"Max={max}");
            Console.WriteLine($"Sum={s}");
            Console.WriteLine($"Avg={(double)s/num.Length}");
        }
    }
}

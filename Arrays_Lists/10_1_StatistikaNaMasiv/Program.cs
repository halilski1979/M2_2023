using System;
using System.Linq;

namespace _10_1_StatistikaNaMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int s = 0;
            int s1 = 0;
            int s2 = 0;
            int min = int.MaxValue;
            int min1 = int.MaxValue;

            for (int i = 0; i < num.Length; i++)
            {
                s += num[i];
            }

            foreach (var item in num)
            {
                s1 += item;
            }

            s2 = num.Sum();

            Console.WriteLine(s);
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine("******Най-малък елемент*********");
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]<min)
                {
                    min = num[i];
                }
            }
            foreach (var item in num)
            {
                if (item<min1)
                {
                    min1 = item;
                }
            }

            int min2 = num.Min();

            Console.WriteLine(min);
            Console.WriteLine(min1);
            Console.WriteLine(min2);

        }
    }
}

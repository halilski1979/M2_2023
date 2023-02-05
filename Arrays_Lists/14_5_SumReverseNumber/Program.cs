using System;
using System.Linq;

namespace _14_5_SumReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < list.Count(); i++)
            {
                list[i] = String.Join("", list[i].Reverse());
            }
            int sum = list.Select(int.Parse).Sum();
            Console.WriteLine(sum);
        }
    }
}

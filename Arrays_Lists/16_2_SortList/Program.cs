using System;
using System.Linq;

namespace _16_2_SortList
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            num.Sort();
            Console.WriteLine(string.Join(" <= ",num));
        }
    }
}

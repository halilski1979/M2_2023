using System;
using System.Linq;

namespace _15_2._1_DeleteLastNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastN = num.Last();
            int br = 0;

            while (num.Contains(lastN))
            {
                num.Remove(lastN);
                br++;

            }
            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(br);
        }
    }
}

using System;
using System.Linq;

namespace _15_3_DeleteNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]<0)
                {
                    num.Remove(num[i]);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ",num));
        }
    }
}

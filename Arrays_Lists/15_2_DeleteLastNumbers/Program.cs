using System;
using System.Linq;

namespace _15_2_DeleteLastNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lastNumber = num[num.Count-1];

            for (int i = 0; i < num.Count; i++)
            {
                if (num[i]==lastNumber)
                {
                    num.Remove(num[i]);
                }
            }

            Console.WriteLine(string.Join(" ",num));
        }
    }
}

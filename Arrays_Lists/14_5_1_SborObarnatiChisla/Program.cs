using System;
using System.Linq;

namespace _14_5_1_SborObarnatiChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').ToList();

            for (int i = 0; i < num.Count; i++)
            {
                num[i] = string.Join("",num[i].Reverse());
            }
            Console.WriteLine(string.Join(" ",num));
            int sum = num.Select(int.Parse).Sum();
            Console.WriteLine(sum);
            
        }
    }
}

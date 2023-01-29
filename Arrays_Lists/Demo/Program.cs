using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("*****************");
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"num[{i}]={num[i]}");
            }
        }
    }
}

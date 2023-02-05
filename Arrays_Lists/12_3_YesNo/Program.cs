using System;
using System.Linq;

namespace _12_3_YesNo
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            bool flag = false;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i]==n)
                {
                    flag = true;                   
                }
            }

            if (flag)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

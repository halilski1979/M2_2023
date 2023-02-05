using System;
using System.Collections.Generic;

namespace Demo4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> names = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"names[{i}]=");
                names.Add();
            }
            Console.WriteLine(string.Join(" ",names));
        }
    }
}

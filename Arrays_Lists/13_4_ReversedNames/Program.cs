using System;
using System.Linq;

namespace _13_4_ReversedNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(',').ToList();
            foreach (var item in names)
            {
                Console.WriteLine(string.Join(" ", item.Split(' ').Reverse()));
            }


        }
    }
}

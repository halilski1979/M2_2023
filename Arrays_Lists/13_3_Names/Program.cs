using System;
using System.Linq;

namespace _13_3_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine(string.Join("; ",names));
            names.Reverse();
            Console.WriteLine(string.Join("; ", names));
        }
    }
}

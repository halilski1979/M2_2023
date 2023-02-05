using System;
using System.Linq;

namespace Demo3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход нa елементи от 1 ред

            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var names = Console.ReadLine().Split(' ').ToList();

            Console.WriteLine(string.Join(" ",num));
            Console.WriteLine(string.Join(" ",names));



        }
    }
}

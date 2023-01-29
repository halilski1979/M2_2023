using System;

namespace _06_4_Pravoagalnik
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(2*a+2*b);
            Console.WriteLine(a*b);
            Console.WriteLine(Math.Sqrt(a*a+Math.Pow(b,2)));
        }
    }
}

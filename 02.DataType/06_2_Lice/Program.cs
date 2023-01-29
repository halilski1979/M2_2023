using System;

namespace _06_2_Lice
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;
            Console.WriteLine($"{area:f12}");
            Console.WriteLine(Math.Round(area,12));
        }
    }
}

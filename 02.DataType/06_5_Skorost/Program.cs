using System;

namespace _06_5_Skorost
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double s = double.Parse(Console.ReadLine());

            double tSec = h * 3600 + m * 60 + s;
            double mSec = n / tSec;
            Console.WriteLine($"{mSec:f7}");

            double kmH = (n/1000) / (tSec/3600);
            Console.WriteLine($"{kmH:f7}");

            double miliH = (n / 1609) / (tSec / 3600);
            Console.WriteLine($"{miliH:f7}");
        }
    }
}

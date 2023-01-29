using System;

namespace _07_1_Asansyor
{
    class Program
    {
        static void Main(string[] args)
        {
            int brH = int.Parse(Console.ReadLine());
            int kapacitet = int.Parse(Console.ReadLine());

            if (brH%kapacitet>0)
            {
                int kurs = brH / kapacitet + 1;
                Console.WriteLine(kurs);
            }
            else
            {
                int kurs = brH / kapacitet;
                Console.WriteLine(kurs);
            }
            
            
            
           
        }
    }
}

using System;
using System.Linq;

namespace _01._DeklariraneMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //1  начин
            int[] num1 = new int[8];

            //2 начин
            int[] num2 = new int[] {2,5,11,6,8,2};

            //3 начин
           

            string[] days = new string[] {"Po","Vt","Sr","Ch","Pe","Sa","Ne"};
            

            //Печат 1 - string.join
            Console.WriteLine(string.Join(" ",days));

            //Печат 2 - for
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine($"days[{i}]={days[i]}");
            }



        }
    }
}

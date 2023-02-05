using System;
using System.Linq;

namespace Demo2_MetodiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = new int[] { 2 ,4,- 5,1,10 };
            Console.WriteLine(string.Join(" ", num));

            Array.Reverse(num);           
            Console.WriteLine(string.Join(" ",num));

            //Array.Sort(num);
            num = num.OrderByDescending(x => x).ToArray();
            Console.WriteLine(string.Join(" ", num));

            Array.Clear(num,2,2);
            Console.WriteLine(string.Join(" ", num));
        }
    }
}

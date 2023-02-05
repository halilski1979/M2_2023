using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var num = new int[n];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"num[{i}]=");
                num[i] = int.Parse(Console.ReadLine());
            }

            //string.Join
            Console.WriteLine(string.Join(",",num));
            Console.WriteLine("******");

            //Печат for
            for (int i = 0; i <num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("******");

            //Печат foreach
           
            foreach (var item in num)
            {
                Console.WriteLine(item);
            }

        }
    }
}

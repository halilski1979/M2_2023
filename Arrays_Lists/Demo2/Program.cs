using System;
using System.Collections.Generic;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<int> num = new List<int>();

            var numsMasiv = new int[] {1,2,3,4,5};
            List<string> names = new List<string>() { "Ivan","Asen","Petar","Miro" };

            Console.WriteLine(string.Join(" ",numsMasiv));
            Console.WriteLine(string.Join(",",names));

            for (int i = 0; i < numsMasiv.Length; i++)
            {
                Console.WriteLine($"numsMasiv[{i}]={numsMasiv[i]}");
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"names[{i}]={names[i]}");
            }

            foreach (var elMasiv in numsMasiv)
            {
                Console.WriteLine(elMasiv);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }



        }
    }
}

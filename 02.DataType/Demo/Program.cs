using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 97; i < 127; i++)
            {
                Console.WriteLine($"{i}=>{(char)i}");
            }

        }
    }
}

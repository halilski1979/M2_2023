using System;
using System.Linq;

namespace _12_2_InsertElementMasiv
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            var newArr = new int[num.Length+1];

            num = num.OrderBy(x => x).ToArray();
            Console.WriteLine(string.Join(" ",num));

            // Въвведенето число е по-малко от първият елемент
            if (n<num.Min())
            {
                newArr[0] = n;
                for (int i = 1; i < newArr.Length; i++)
                {
                    newArr[i] = num[i - 1];
                }
            }

            // Въведеното число е по-голямо от последният елемент
            else if (n>=num.Max())
            {
                newArr[newArr.Length - 1] = n;
                for (int i = 0; i < newArr.Length-1; i++)
                {
                    newArr[i] = num[i];
                }
            }

            else
            {
                int j = 0;
                for (int i = 0; i <newArr.Length; i++)
                {
                    if (n>=num[i])
                    {
                        newArr[i] = num[i];
                        j++;
                    }
                    else
                    {
                        break;
                    }
                }

                newArr[j] = n;
                for (int i =j+1; i < newArr.Length; i++)
                {
                    newArr[i] = num[i - 1];
                }
            }


            Console.WriteLine(string.Join(" ",newArr));

           

        }
    }
}

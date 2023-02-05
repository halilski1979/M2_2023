using System;
using System.Collections.Generic;

namespace Demo5_SpisaciMetodi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 2, 4, 6, 8, 4, 10, 12 };

            Console.WriteLine(string.Join(" ",num));

            //Добавяне на елемент напоследна позиция
            num.Add(14);
            Console.WriteLine(string.Join(" ", num));

            //Изтриване на конкретен елемент
            num.Remove(4);
            Console.WriteLine(string.Join(" ", num));

            //Изтриване на елeмент по индекс
            num.RemoveAt(0);
            Console.WriteLine(string.Join(" ", num));

            //Обръщане на елементи на списък
            num.Reverse();
            Console.WriteLine(string.Join(" ", num));

            //Вмъкване на елемент
            num.Insert(0,11);
            Console.WriteLine(string.Join(" ", num));
           

        }
    }
}

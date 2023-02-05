using System;
using System.Linq;

namespace _14_2_ChetniChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i]%2==0)
                {
                    Console.Write(nums[i] + " ");
                }
            }
            Console.WriteLine();
            foreach (var item in nums)
            {
                if (item%2==0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
            nums=nums.Where(x => x >4).ToList();
            Console.WriteLine(string.Join(" ",nums));

        }
    }
}

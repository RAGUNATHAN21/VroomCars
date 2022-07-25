using System;
using System.Linq;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var res = nums.Where(n => n % 2 != 0);

            foreach (var num in res)
                Console.WriteLine(num);

            Console.ReadKey();
        }
    }
}
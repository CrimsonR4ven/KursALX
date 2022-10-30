using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursALX.Lessons.L2
{
    public class L2Conditionals
    {
        public static void Run()
        {
            
        }
        private static void fajn()
        {
            Console.Write("Enter Number:");
            var number = Int32.Parse(Console.ReadLine());
            Console.Write("Enter limit1:");
            var limit1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter limit2:");
            var limit2 = Int32.Parse(Console.ReadLine());
            IsEven(number);
            WithinLimits(limit1, limit2, number);
        }
        private static void IsEven(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is an even number");
            }
            else
            {
                Console.WriteLine($"The number {number} is an odd number");
            }
        }
        private static void WithinLimits(int limit1, int limit2, int number)
        {
            if (number < limit1)
            {
                Console.WriteLine($"{number} is smaller than {limit1}");
            }
            else if (number > limit2)
            {
                Console.WriteLine($"{number} is Larger that {limit2}");
            }
            else
            {
                Console.WriteLine($"{number} is beetwen {limit1} and {limit2}");
            }
        }
    }
}

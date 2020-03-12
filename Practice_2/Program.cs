using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_2
{
    class Program
    {
        public static IEnumerable<int> Fibonacci()
        {
            int current = 0;
            int next = 1;
            while (true)
            {
                yield return current;
                int temp = next;
                next = current + next;
                current = temp;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Fibonacci().TakeWhile(x => x < n)
                          .Where(x => x % 2 == 0)
                          .Sum();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

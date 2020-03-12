using System;
using System.Linq;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = Enumerable.Range(1, n).Aggregate(1, (p, item) => p * item);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input n:");
            int num = Convert.ToInt32(Console.ReadLine());
            int n1 = 0, n2 = 1, n3 = 0;

            var result = Enumerable.Range(1, num).Select(n =>
            {
                n3 = n1 + n2;
                int res = n3;
                n1 = n2;
                n2 = n3;
                return res;
            }).Reverse().First();
            Console.WriteLine(result); 
            Console.ReadKey();
        }
    }
}

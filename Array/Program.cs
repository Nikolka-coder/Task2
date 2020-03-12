using System;
using System.Linq;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randNum = { 2, 3, 4, 5, 6, 7 };
             var lookup = randNum.ToLookup(num => num & 1);
            var even = randNum.Where(num => (num & 1) == 0).ToArray();
            for (int i = 0; i < even.Length; i++)
            {
                Console.Write(even[i] + " ");
            }
             var odd = randNum.Where(num => (num & 1) == 1).ToArray();
            Console.WriteLine();
            for (int i = 0; i < odd.Length; i++)
            {
                Console.Write(odd[i]+" ");
            }
            Console.ReadLine();
        }
    }
}

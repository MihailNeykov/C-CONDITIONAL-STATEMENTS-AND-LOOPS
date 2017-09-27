using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < 2*n; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine($"{i}");
                    sum += i;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

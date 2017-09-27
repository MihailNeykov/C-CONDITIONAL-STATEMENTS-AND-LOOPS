using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int sumMax = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {

                    if (sum >= sumMax)
                    {
                        break;
                    }
                    sum += 3 * i * j;
                    
                    counter++;
                }
            }
            if (sum < sumMax)
            {
                Console.WriteLine($"{counter} combinations\nSum: {sum}");

            }
            else
            {
                Console.WriteLine($"{counter} combinations\nSum: {sum} >= {sumMax}");
            }
           

        }
    }
}

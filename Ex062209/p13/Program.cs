using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magical = int.Parse(Console.ReadLine());
            int counter = 0;
            bool equalsMagic = false;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    counter++;
                    if (i + j == magical)
                    {
                        Console.WriteLine($"Number found! {j} + {i} = {magical}");
                        equalsMagic = true;
                        return;
                    }
                    
                        
                    
                }
            }
            if (equalsMagic == false) {
                Console.WriteLine($"{counter} combinations - neither equals {magical}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if(a>=b)
            {
                for (int i = b; i <= a; i++)
                {
                    Console.WriteLine("{0}",i);

                }
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine($"{i}");

                }
            }
        }
    }
}

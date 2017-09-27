using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14
{
    class Program
    {
        static void Main(string[] args)
        {
            Char fisrt = Char.Parse(Console.ReadLine());
            Char last = Char.Parse(Console.ReadLine());
            Char excluded = Char.Parse(Console.ReadLine());

            for (Char i = fisrt; i <= last; i++)
            {
                for (Char j = fisrt; j <= last; j++)
                {
                    for (Char k = fisrt; k <= last; k++)
                    {
                        if(i!=excluded && j!= excluded && k != excluded)
                        {
                            Console.Write($"{i}{j}{k} ");
                        
                        }
                    }
                }
            }

        }
    }
}

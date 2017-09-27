using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = "";
            int counter = 0;

            while (ingredient != "Bake!")
            {
                ingredient = Console.ReadLine();
                if (ingredient != "Bake!")
                {
                    Console.WriteLine($"Adding ingredient {ingredient}.");
                    counter++;
                }
            
            }

            Console.WriteLine($"Preparing cake with {counter} ingredients.");

        }
    }
}

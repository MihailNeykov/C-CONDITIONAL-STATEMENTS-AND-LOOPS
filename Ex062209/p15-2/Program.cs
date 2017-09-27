using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PeshoDamage = Double.Parse(Console.ReadLine());
            Double GoshoDamage = Double.Parse(Console.ReadLine());
            Double GoshoHealth = 100;
            Double PeshoHealth = 100;
            int counter = 1;

            while (GoshoHealth > 0 && PeshoHealth > 0)
            {

                if (counter % 2 != 0)
                {
                    GoshoHealth -= PeshoDamage;

                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                else
                {
                    PeshoHealth -= GoshoDamage;

                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {counter}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                }

                if (counter % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }

                counter++;

            }
        }
    }
}

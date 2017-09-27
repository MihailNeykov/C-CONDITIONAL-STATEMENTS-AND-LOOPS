using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p15
{
    class Program
    {
        static void Main(string[] args)
        {
            Double PeshoDamage = Double.Parse(Console.ReadLine());
            Double GoshoDamage = Double.Parse(Console.ReadLine());
            Double GoshoHealth = 100;
            Double PeshoHealth = 100;

            for (int i = 1; i <= 1000; i++)
            {
                
                


                if (i % 2 != 0)
                {
                    GoshoHealth -= PeshoDamage;
                    
                    if (GoshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoHealth} health.");
                }
                else
                {
                    PeshoHealth -= GoshoDamage;
                   
                    if (PeshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoHealth} health.");
                }

                if (i % 3 == 0)
                {
                    PeshoHealth += 10;
                    GoshoHealth += 10;
                }




            }

        
        }
    }
}

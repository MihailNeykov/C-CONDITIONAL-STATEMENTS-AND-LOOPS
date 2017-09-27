using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            
            double price = 0;


            switch (profession)
            {
                case "Athlete":
                    
                    price = 0.7 * quantity;
                    break;
                case "Businessman":
                case "Businesswoman":
                    
                    price = quantity;
                    break;
                case "SoftUni Student":
                   
                    price = 1.7 * quantity;
                    break;
                default:
                   
                    price = 1.2 * quantity;
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}

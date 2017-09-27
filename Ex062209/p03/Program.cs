using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = "";
            double price = 0;
            double pricePerPerson = 0;

            if (people <= 50)
            {
                hall = "Small Hall";
                price += 2500;
            }else if(people <= 100)
            {
                hall = "Terrace";
                price += 5000;
            }
            else if(people<=120)
            {
                hall = "Great Hall";
                price += 7500;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        
            switch (package)
            {
                case "Normal":
                    price += 500;
                    price *= 0.95;
                    break;
                case "Gold":
                    price += 750;
                    price *= 0.9;
                    break;
                case "Platinum":
                    price += 1000;
                    price *= 0.85;
                    break;
            }

            pricePerPerson = price / people;

            if (people > 0 && people <= 120)
            {
                Console.WriteLine($"We can offer you the {hall}\nThe price per person is {pricePerPerson:F2}$");
            }

        }
    }
}

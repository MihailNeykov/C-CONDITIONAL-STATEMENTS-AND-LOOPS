using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceDouble = 0;
            double priceSuite = 0;
  
            switch(month)
            {
                case "May":
                case "October":
                    priceStudio = 50;
                    priceDouble = 65;
                    priceSuite = 75;
                    if (nights > 7)
                    {
                       priceStudio *= 0.95;
                    }
                    if ((month == "September" || month == "October") && nights > 7)
                    {
                        double discount = 1 / nights;
                        priceStudio *= (1-discount);
                    }
                    break;
                
                case "September":
                case "June":
                    priceStudio = 60;
                    priceDouble = 72;
                    priceSuite = 82;
                    if (nights > 14)
                    {
                        priceDouble *= 0.9;
                    }
                    if ((month == "September" || month == "October") && nights > 7)
                    {
                        double discount = 1 / nights;
                        priceStudio *= (1 - discount);
                    }

                    break;
                case "July":
                case "August":
                case "December":
                    priceStudio = 68;
                    priceDouble = 77;
                    priceSuite = 89;
                    if (nights > 14)
                    {
                        priceSuite *= 0.85;
                    }
                    break;  
            }
           
        
           

            Console.WriteLine($"Studio: {priceStudio*nights:F2} lv.\nDouble: {priceDouble* nights:F2} lv.\nSuite: {priceSuite* nights:F2} lv.");


        


        }
    }
}

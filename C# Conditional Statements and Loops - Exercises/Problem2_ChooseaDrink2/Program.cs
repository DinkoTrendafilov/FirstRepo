using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2_ChooseaDrink2
{
    class Program
    {
        static void Main(string[] args)
        {

            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal toPay = 0.0m;
            switch (profession)
            {
                case "Athlete":
                    toPay = 0.7m;
                    break;
                case "Businessman":
                case "Businesswoman":
                    toPay = 1.00m;
                    break;
                case "SoftUni Student":
                    toPay = 1.70m;
                    break;
                default:
                    toPay = 1.20m;
                    break;
            }
                 Console.WriteLine($"The {profession} has to pay {quantity * toPay:f2}.");



        }
    }
}

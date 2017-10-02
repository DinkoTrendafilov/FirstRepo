using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {

            string foodProduct = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double tottalEnergy = (energyContent / 100) * volume;
            double tottalSugar = (sugarContent / 100) * volume;


            Console.WriteLine($"{volume}ml {foodProduct}:");
            Console.WriteLine($"{tottalEnergy}kcal, {tottalSugar}g sugars");

        }
    }
}

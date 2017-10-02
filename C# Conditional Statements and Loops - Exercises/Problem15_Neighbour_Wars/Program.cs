using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {

            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealt = 100;
            const string peshoAttackType = "Roundhouse kick";
            const string goshoAttackType = "Thunderous fist";
            int round = 1;

            while (true)
            {
                if (round % 2 != 0)
                {
                    //Pesho attacking
                    goshoHealt = goshoHealt - peshoDamage;
                    if (goshoHealt <= 0)
                    {
                        Console.WriteLine($"Pesho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Pesho used {peshoAttackType} and reduced Gosho to {goshoHealt} health.");
                }
                else
                {
                    //Gosho attacking
                    peshoHealth = peshoHealth - goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {round}th round.");
                        break;
                    }
                    Console.WriteLine($"Gosho used {goshoAttackType} and reduced Pesho to {peshoHealth} health.");
                }

                if (round % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealt += 10;
                }
                round++;

            } 
          }   
    }
}

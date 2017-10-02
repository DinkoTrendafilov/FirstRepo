using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] ingredient = new string[20];
            int counter = 0;
            for (int i = 0; i < ingredient.Length; i++)
            {
                ingredient[i] = Console.ReadLine();
                if (ingredient.Contains("Bake!"))
                    break;
                counter++;
            }
             for (int i = 0; i < counter; i++)
            Console.WriteLine($"Adding ingredient {ingredient[i]}.");
            Console.WriteLine($"Preparing cake with {counter} ingredients.");


                        
        }
    }
}

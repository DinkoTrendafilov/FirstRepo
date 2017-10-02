using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;
            bool isEqual = false;
            string output = string.Empty;
            for (int i = n; i <= m; i++)
                for (int j = n; j <= m; j++)
                {
                    int sum = i + j;
                    count++;
                    if (sum == magicNumber)
                    {
                        isEqual = true;
                        output = $"Number found! {i} + {j} = {sum}";
                    }
                }
            if (isEqual)
                Console.WriteLine(output);
            else
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");

            
        }
    }
}

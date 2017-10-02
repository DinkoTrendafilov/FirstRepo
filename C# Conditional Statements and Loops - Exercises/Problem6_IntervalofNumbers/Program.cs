using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6_IntervalofNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int small = 0, big = 0;
            if (firstNum < secNum)
            {
                small = firstNum;
                big = secNum;
            }
            else
            {
                small = secNum;
                big = firstNum;
            }
            for (int i = small; i <= big; i++)
                Console.WriteLine(i);


            
        }
    }
}

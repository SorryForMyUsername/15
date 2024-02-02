using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for(int x = -5; x <= 5; x += 2)
            //{
            //    Console.WriteLine($"x = {x}\ty = {-5 * Math.Pow(x, 2) + 2 * x + 1}");
            //}

            //Вариант 7
            for (double x = 0; x <= 2; x += 0.2)
            {
                Console.WriteLine($"x = {x}\ty = {Math.Sqrt(x) / (x + 1)}");
            }

            Console.ReadKey();
        }
    }
}

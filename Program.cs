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
            //Средний
            try
            {
                double U, k, y;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Введите k:");
                k = double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Введите y:");
                y = double.Parse(Console.ReadLine());
                U = (Math.Log(2,k + 4.3)) / (Math.Exp(k + y) + Math.Sqrt(y));
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Результат U:" + U);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
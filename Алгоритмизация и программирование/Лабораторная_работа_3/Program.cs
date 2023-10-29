using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, a = 2.2, b = 0.3, i; //y - результат вычислений; i - переменные, подаваемые на вход; a, b - заданные переменные;

            Console.WriteLine("Программа для вычисления значения функции y в зависимости от интервала, в котором лежит значение переменной i");
            Console.WriteLine("    |  a*i^4 + b*i               при i < 10");
            Console.WriteLine("y = |  tg(i + 0.5)               при i = 10");
            Console.WriteLine("    |  e^(2*i) + √(a^2 + i^2)    при i > 10");

            Console.WriteLine("Введите i принадлежащее интервалу [7,12] : ");
            i = Convert.ToDouble(Console.ReadLine());

            if (i < 10 && i >= 7)
            {
                y = a * Math.Pow(i, 4) + b * i;
                Console.WriteLine($"y({i}) = {y}");
            }
            else if (i == 10)
            {
                y = Math.Tan(i + 0.5);
                Console.WriteLine($"y({i}) = {y}");
            }
            else if (i > 10 && i <= 12)
            {
                y = Math.Pow(Math.E, 2 * i) + Math.Sqrt(Math.Pow(a, 2) + Math.Pow(i, 2));
                Console.WriteLine($"y({i}) = {y}");
            }
            else
            {
                Console.WriteLine($"Вводимый аргумент i не принадлежит интервалу [7,12]");
            }
        }
    }
}

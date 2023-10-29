using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double w, x1, x2, a, b; //w - результат вычислений; a, b, x1, x2 - значения переменных, подаваемые на вход

            Console.WriteLine("Программа для вычисления значения формулы:");
            Console.WriteLine("       x^3 + a^2 * cos2x     ");
            Console.WriteLine("w = —————————————————————————");
            Console.WriteLine("      x + √(a + b * sin3x)   ");

            Console.WriteLine("Введите значение x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение b: ");
            b = Convert.ToDouble(Console.ReadLine());

            w = (Math.Pow(x1, 3) + Math.Pow(a, 2) * Math.Cos(2 * x1)) / (x1 + Math.Sqrt(a + b * Math.Sin(3 * x1)));
            Console.WriteLine($"y({x1}) = {w}"); 

            w = (Math.Pow(x2, 3) + Math.Pow(a, 2) * Math.Cos(2 * x2)) / (x2 + Math.Sqrt(a + b * Math.Sin(3 * x2)));
            Console.WriteLine($"y({x2}) = {w}");
        }
    }
}

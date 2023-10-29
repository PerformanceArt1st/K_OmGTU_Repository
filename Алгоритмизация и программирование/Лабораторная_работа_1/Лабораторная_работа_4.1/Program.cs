using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, x, n; //y - результат вычислений; x, n - переменные, подаваемые на вход;

            Console.WriteLine("Программа для вычисления значения формулы:");
            Console.WriteLine("        x   x          x    ");
            Console.WriteLine("Y = x + — + — + ... + ———   ");
            Console.WriteLine("        3   5          17   ");
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение n: ");
            n = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                y += x / (1 + i * 2);
            }

            Console.WriteLine($"Y = {y}");
        }
    }
}

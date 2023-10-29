using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, z, step = 0; //z - результат вычислений; x, a, step - данные, подаваемые на вход;

            Console.WriteLine("Программа для табуляции функций в зависимости от значений переменных x и a");
            Console.WriteLine("    |    a(e^(x+2a)+e^(-(x-3a))),    если  0,1 <= x < 0,5");
            Console.WriteLine("z = |    sin x,                      если  x = 0,5, a = 2; 2,1");
            Console.WriteLine("    |    a + a cos(x+3a),            если  0,5 < x <= 1,5, шаг dx=a/10");

            Console.WriteLine("Введите x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"|{"x",-32}|z");
            Console.WriteLine($"|{" ",-32}| ");
            for (double a = 2.0; a < 2.2; a += 0.1)
            {
                step = a / 10;
                for (double i = x; i <= 1.5; i += step)
                {
                    if ((0.1 <= i) & (i < 0.5))
                    {
                        z = a * (Math.Pow(Math.E, i + 2 * a) + Math.Pow(Math.E, -(i - 3 * a)));
                        Console.WriteLine($"|При x = {i} и a = {a, -14} |z = a(e ^ (x + 2a) + e ^ (-(x - 3a))) = {z}");
                    }
                    else if (i == 0.5)
                    {
                        z = Math.Sin(i);
                        Console.WriteLine($"|При x = {i} и a = {a, -14} |z = sin x = {z}");
                    }
                    else if ((0.5 < i) & (i <= 1.5))
                    {
                        z = a + a * Math.Cos(i + 3 * a);
                        Console.WriteLine($"|При x = {i} и a = {a, -14} |z = a + a cos(x+3a) = {z}");
                    }
                }
            }
        }
    }
}

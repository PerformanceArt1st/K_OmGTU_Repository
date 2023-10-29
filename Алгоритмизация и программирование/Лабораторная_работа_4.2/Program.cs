using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 2 * Math.PI, n, f1, f2; //a, b, n - переменные, подаваемые на вход; f1, f2 - переменные, хранящие значения функций;

            Console.WriteLine("Программа для вычисления значений функций (5-3 cosx) и (√(1+sin^2x)) в n равномерно распределенных в диапазоне а<=x<=b точках");
            Console.WriteLine("Введите n: ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"|{"x",-30}|{"F1(х)",-30}|{"F2(х)",-30}|");
            Console.WriteLine(new string('—', 94));


            for (double x = a; x < b; x += (b - a) / n)
            {
                f1 = 5 - 3 * Math.Cos(x);
                f2 = Math.Sqrt(1 + Math.Pow(Math.Sin(x), 2));
                Console.Write($"|{x, - 30}|");
                Console.Write($"{f1, - 30}|");
                Console.Write($"{f2, - 30}|");
                Console.WriteLine();
            }
        }
    }
}

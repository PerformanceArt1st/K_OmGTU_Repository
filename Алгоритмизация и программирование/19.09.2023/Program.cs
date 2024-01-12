using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._09._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность из 10 чисел");
            int[] arr = new int[10];
            

            for (int i = 0; i < 10; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr.Max(), count_otr = 0, sum_pol = 0, min = arr[0];

            for (int i = 0; i < 10; i++)
            {
                if (arr[i] < 0)
                {
                    count_otr++;
                }
                if ((arr[i] > 0) && (arr[i] % 3 == 0))
                {
                    sum_pol += arr[i];
                }
                if ((arr[i] > 0) && ((arr[i] < min) || (min < 0)))
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Максимальный элемент: {max}");
            Console.WriteLine($"Количество отрицательных: {count_otr}");
            Console.WriteLine($"Сумма положительных кратных 3: {sum_pol}");
            if (min < 0) Console.WriteLine($"Минимальных среди положительных нет");
            else Console.WriteLine($"Минимальный среди положительных: {min}");
        }
    }
}

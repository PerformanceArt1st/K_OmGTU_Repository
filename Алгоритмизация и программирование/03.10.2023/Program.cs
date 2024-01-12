using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._10._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            int otv1 = 0, otv2 = 0, otv3 = 0, sum_tsifr = 0;
            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Задание 1
                Console.Write($"Введите элемент номер {i+1}: ");
                int a = int.Parse(Console.ReadLine());
                if ((a % 3 == a % 5) && (a % 5 == a % 7))
                {
                    otv1++;
                }
                int a1 = a;
                //Задание 2
                while (a1 > 0)
                {
                    if (a1 % 10 == 7)
                    {
                        otv2++;
                        break;
                    }
                    a1 /= 10;
                }
                //Задание 3
                while (a > 0)
                {
                    sum_tsifr += a % 10;
                    a /= 10;
                }
                if (sum_tsifr % 7 == 0)
                {
                    otv3++;
                }
            }
            Console.WriteLine($" *** Количество элементов, запись которых в трёх/пяти/семи-ричных системах одинаковы: {otv1}");
            
            Console.WriteLine($" *** Элементы, содержащие минимум одну семёрку: {otv2}");
            if (otv3 == n)
                Console.WriteLine(" *** У всех элементов сумма цифр кратна 7");
            else
                Console.WriteLine(" *** Не у всех элементов сумма цифр кратна 7");
        }
    }
}

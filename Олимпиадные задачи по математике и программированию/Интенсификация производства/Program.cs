﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intensifikatsiya_proizvodstva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первую дату: ");
            string data1 = Console.ReadLine();
            Console.Write("Введите вторую дату: ");
            string data2 = Console.ReadLine();
            Console.Write("Введите начальный выпуск продукции: ");
            int n = int.Parse(Console.ReadLine());
            string[] arr_data1 = data1.Split('.');
            int day1 = int.Parse(arr_data1[0]);
            int mounth1 = int.Parse(arr_data1[1]);
            int year1 = int.Parse(arr_data1[2]);
            string[] arr_data2 = data2.Split('.');
            int day2 = int.Parse(arr_data2[0]);
            int mounth2 = int.Parse(arr_data2[1]);
            int year2 = int.Parse(arr_data2[2]);
            int sum_years = 0, sum_mounth = 0, sum_days = 0, answer = 0;
            for (int i = year1 + 1; i <= year2; i++)
            {
                if (i % 4 == 0)
                    sum_years += 366;
                else
                    sum_years += 365;
            }
            if (mounth1 <= mounth2)
            {
                for (int i = mounth1; i < mounth2; i++)
                {
                    switch (i)
                    {
                        case 2:
                            sum_mounth += 28;
                            break;
                        case 4:
                            sum_mounth += 30;
                            break;
                        case 6:
                            sum_mounth += 30;
                            break;
                        case 9:
                            sum_mounth += 30;
                            break;
                        case 11:
                            sum_mounth += 30;
                            break;
                        default:
                            sum_mounth += 31;
                            break;
                    }
                }
            }
            else if (mounth1 > mounth2)
            {
                for (int i = mounth2; i < mounth1; i++)
                {
                    switch (i)
                    {
                        case 2:
                            sum_mounth -= 28;
                            break;
                        case 4:
                            sum_mounth -= 30;
                            break;
                        case 6:
                            sum_mounth -= 30;
                            break;
                        case 9:
                            sum_mounth -= 30;
                            break;
                        case 11:
                            sum_mounth -= 30;
                            break;
                        default:
                            sum_mounth -= 31;
                            break;
                    }
                }
            }
            sum_days = day2 - day1 + 1;
            int sum = sum_days + sum_mounth + sum_years;
            for (int i = 1; i <= sum; i++)
            {
                answer += n;
                n += 1;
            }
            Console.WriteLine("Ответ: " + answer);
        }
    }
}

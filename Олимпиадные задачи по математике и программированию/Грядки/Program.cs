using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gryadki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ввседите длину грядки: ");
            int L = int.Parse(Console.ReadLine());
            Console.Write("Ввседите ширина грядки: ");
            int K = int.Parse(Console.ReadLine());
            Console.Write("Ввседите расстояние до грядки: ");
            int P = int.Parse(Console.ReadLine());
            Console.Write("Ввседите количество грядок: ");
            int N = int.Parse(Console.ReadLine());
            int answer1 = 0;

            for (int i = 0; i < N; i++) //через цикл
            {
                answer1 += 2 * (K + L + P) + 2 * i * L;
            }

            Console.WriteLine(answer1);


            int answer2 = (2 * N * (K + L + P)) + L * N * (N - 1); //через формулу

            Console.WriteLine(answer2);
        }
    }
}

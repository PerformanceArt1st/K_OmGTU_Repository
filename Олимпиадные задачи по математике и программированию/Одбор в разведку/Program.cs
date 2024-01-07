using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otbor_v_razvedku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество солдат: ");
            int n = int.Parse(Console.ReadLine());
            int k = 0, c;
            if (n >= 3)
            {
                c = 1;
                while (c <= n / 2)
                {
                    c *= 2;
                }
                if (n <= c + c / 2)
                {
                    k = n - c;
                }
                else
                {
                    k = 2 * c - n;
                }
            }
            Console.WriteLine("Ответ: " + k);
        }
    }
}

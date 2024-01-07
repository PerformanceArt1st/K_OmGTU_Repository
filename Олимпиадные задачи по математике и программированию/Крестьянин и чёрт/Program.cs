using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krest_yanin_i_chort
{
    class Program
    {
        static void Main(string[] args)
        {
            float counter = 0;
            Console.Write("Введите макс кол-во монет: ");
            float MaxN = int.Parse(Console.ReadLine());
            for (float i = 1; i <= MaxN; i++)
            {
                float n = i;
                for (float k = 1; k <= i * 2; k++)
                {
                    if (k >= i)
                    {

                        n = i;
                        while (n > 0)
                        {
                            float t = n;
                            n = n * 2 - k;
                            if (n >= t)
                            {
                                break;
                            }
                        }
                        if (n == 0)
                        {
                            counter += 1;
                        }
                    }
                }
            }
            Console.WriteLine("Ответ: " + counter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину новой стены: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину новой стены: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите длину уцелевшей стены: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену ремонта метра уцелевшей стены: ");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену разбора метра уцелевшей стены: ");
            int c2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену строительства метра из уцелевшего материала стены: ");
            int c3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену строительства метра стены из нового материала: ");
            int c4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену метра нового материала: ");
            int c5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите цену вывоза на материала свалку: ");
            int c6 = Convert.ToInt32(Console.ReadLine());

            int max = Math.Max(x, y);
            int p = 2 * (x + y);
            int s = 0;
			int ostatok;
			int f1 = c2 + c3; //цена работы с уцелевшей стеной
			int f2 = c2 + c4 + c5 + c6; //цена работы с новой стеной (с разбором старой и вывозом мусора)
			int f3 = c4 + c5 + c6; //цена работы с новой стеной (с вывозом мусора)
			int f4 = c4 + c5; //цена работы с новой стеной
			if (l > max)
			{
				s = (l - max) * c2;
				ostatok = l - max;
				p -= max;
				if ((f1 > c1) & (f2 > c1))
				{
					s += max * c1;
				}
				else if (f2 > f1)
				{
					s += max * (f1);
				}
				else
				{
					s += max * (f2);
				}
				if (c3 < f3)
				{
					if (ostatok <= p)
					{
						p -= ostatok;
						s += (ostatok * c3) + (p * f4);
					}
					else
					{
						s += p * c3 + (ostatok - p) * c6;
					}
				}
				else
				{
					s += p * f4 + ostatok * c6;
				}
			}
			else
			{
				if ((f1 > c1) && (f2 > c1))
				{
					s += l * c1;
				}
				else if (f2 > f1)
				{
					s += l * (f1);
				}
			else
				{
					s += l * (f2);
				}
				p -= l;
				s += p * f4;
			}

			Console.WriteLine(s);
		}
    }
}

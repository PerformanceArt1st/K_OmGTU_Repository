using System;
using System.Collections.Generic;

class Program
{
    class Graph : IComparable<Graph>
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Weight { get; set; }

        public int CompareTo(Graph other)
        {
            return this.Weight.CompareTo(other.Weight);
        }
    }

    static void Main(string[] args)
    {
        int sum = 0;
        int v = 5;
        List<Graph> edges = new List<Graph>
        {
            new Graph { Start = 0, End = 3, Weight = 20 },
            new Graph { Start = 0, End = 4, Weight = 10 },
            new Graph { Start = 1, End = 2, Weight = 5 },
            new Graph { Start = 1, End = 3, Weight = 2 },
            new Graph { Start = 2, End = 3, Weight = 4 },
            new Graph { Start = 2, End = 4, Weight = 3 },
            new Graph { Start = 3, End = 4, Weight = 6 }
        };

        List<Graph> res = new List<Graph>();
        int[] p = new int[v];
        int[] r = new int[v];

        for (int i = 0; i < v; i++)
        {
            p[i] = i;
            r[i] = 0;
        }

        edges.Sort();

        for (int i = 0; i < edges.Count; i++)
        {
            int x = edges[i].Start;
            int y = edges[i].End;

            while (p[x] != x)
                x = p[x];
            while (p[y] != y)
                y = p[y];

            if (x != y)
            {
                res.Add(edges[i]);
                if (r[x] < r[y])
                    p[x] = y;
                else if (r[x] > r[y])
                    p[y] = x;
                else
                {
                    p[y] = x;
                    r[x]++;
                }
            }
        }

        Console.WriteLine($" Ребро {' ',1} Вес");

        for (int i = 0; i < res.Count; i++)
        {
            Console.WriteLine($"{res[i].Start+1} ——— {res[i].End+1} {' ',1} {res[i].Weight}");
            sum += res[i].Weight;
        }
        Console.WriteLine("Минимальная остова графа: " + sum);
    }
}
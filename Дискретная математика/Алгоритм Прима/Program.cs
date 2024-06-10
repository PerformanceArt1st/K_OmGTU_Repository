using System;
using System.Collections.Generic;

class Program
{
    class Graph
    {
        public int Start { get; set; }
        public int End { get; set; }
        public int Weight { get; set; }
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

        bool[] m = new bool[v];
        int[] k = new int[v];
        int[] res = new int[v];

        for (int i = 0; i < v; i++)
        {
            k[i] = int.MaxValue;
            m[i] = false;
        }

        k[0] = 0;
        res[0] = -1;

        for (int count = 0; count < v - 1; count++)
        {
            int u = -1;
            int min = int.MaxValue;

            for (int i = 0; i < v; i++)
            {
                if (!m[i] && k[i] < min)
                {
                    min = k[i];
                    u = i;
                }
            }

            m[u] = true;

            for (int i = 0; i < edges.Count; i++)
            {
                int start = edges[i].Start;
                int end = edges[i].End;
                int weight = edges[i].Weight;
                if ((start == u || end == u) && !m[end] && weight < k[end])
                {
                    k[end] = weight;
                    res[end] = u;
                }

                if ((start == u || end == u) && !m[start] && weight < k[start])
                {
                    k[start] = weight;
                    res[start] = u;
                }
            }
        }
        
        Console.WriteLine($" Ребро ");
        for (int i = 1; i < v; i++)
        {
            Console.WriteLine($"{i+1} ——— {res[i]+1}");
            sum += k[i];
        }
        Console.WriteLine("Минимальная остова графа: " + sum);
    }
}

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
        int v = 5;
        int edgesCount = 8;
        List<Graph > edges = new List<Graph >
        {
            new Graph  { Start = 0, End = 1, Weight = -1 },
            new Graph  { Start = 0, End = 2, Weight = 4 },
            new Graph  { Start = 1, End = 2, Weight = 3 },
            new Graph  { Start = 1, End = 3, Weight = 2 },
            new Graph  { Start = 1, End = 4, Weight = 2 },
            new Graph  { Start = 3, End = 2, Weight = 5 },
            new Graph  { Start = 3, End = 1, Weight = 1 },
            new Graph  { Start = 4, End = 3, Weight = -3 }
        };

        int startVertex = 0;
        int[] distance = new int[v];

        for (int i = 0; i < v; i++)
        {
            distance[i] = int.MaxValue;
        }

        distance[startVertex] = 0;

        for (int i = 1; i <= v - 1; i++)
        {
            for (int j = 0; j < edgesCount; j++)
            {
                int u = edges[j].Start;
                int w = edges[j].End;
                int weight = edges[j].Weight;

                if (distance[u] != int.MaxValue && distance[u] + weight < distance[w])
                {
                    distance[w] = distance[u] + weight;
                }
            }
        }

        for (int i = 0; i < edgesCount; i++)
        {
            int u = edges[i].Start;
            int w = edges[i].End;
            int weight = edges[i].Weight;

            if (distance[u] != int.MaxValue && distance[u] + weight < distance[w])
            {
                Console.WriteLine("Граф содержит цикл отрицательного веса");
                return;
            }
        }

        Console.WriteLine("Расстояние от вершины {0} до остальных: \n", startVertex);
        Console.WriteLine("Вершина \tКратчайшее расстояние");
        for (int i = 0; i < v; i++)
        {
            Console.WriteLine("   {0}   ------------>    {1}", i, distance[i]);
        }
    }
}

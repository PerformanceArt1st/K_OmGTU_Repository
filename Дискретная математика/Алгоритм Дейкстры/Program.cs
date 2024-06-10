using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int v = 5;
        int[,] graph = {
            { 0, 10, 0, 30, 100 },
            { 10, 0, 50, 0, 0 },
            { 0, 50, 0, 20, 10 },
            { 30, 0, 20, 0, 60 },
            { 100, 0, 10, 60, 0 }
        };

        int start = 0;
        int[] distance = new int[v];
        bool[] s = new bool[v];

        for (int i = 0; i < v; i++)
        {
            distance[i] = int.MaxValue;
            s[i] = false;
        }

        distance[start] = 0;

        for (int count = 0; count < v - 1; count++)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int w = 0; w < v; w++)
            {
                if (!s[w] && distance[w] <= min)
                {
                    min = distance[w];
                    minIndex = w;
                }
            }

            int u = minIndex;
            s[u] = true;

            for (int w = 0; w < v; w++)
            {
                if (!s[w] && graph[u, w] != 0 && distance[u] != int.MaxValue && distance[u] + graph[u, w] < distance[w])
                {
                    distance[w] = distance[u] + graph[u, w];
                }
            }
        }

        Console.WriteLine("Вершина \tКратчайшее расстояние");
        for (int i = 0; i < v; i++)
        {
            Console.WriteLine("   {0}   ------------>    {1}", i, distance[i]);
        }
    }
}

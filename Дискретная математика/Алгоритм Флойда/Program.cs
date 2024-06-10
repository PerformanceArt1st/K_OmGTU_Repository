using System;

class Program
{
    static void Main(string[] args)
    {
        int V = 4;

        int[,] graph = {
            { 0, 3, int.MaxValue, 5 },
            { 2, 0, int.MaxValue, 4 },
            { int.MaxValue, 1, 0, int.MaxValue },
            { int.MaxValue, int.MaxValue, 2, 0 }
        };

        int[,] dist = new int[V, V];

        for (int i = 0; i < V; i++)
        {
            for (int j = 0; j < V; j++)
            {
                dist[i, j] = graph[i, j];
            }
        }

        for (int k = 0; k < V; k++)
        {
            for (int i = 0; i < V; i++)
            {
                for (int j = 0; j < V; j++)
                {
                    if (dist[i, k] != int.MaxValue && dist[k, j] != int.MaxValue && dist[i, k] + dist[k, j] < dist[i, j])
                    {
                        dist[i, j] = dist[i, k] + dist[k, j];
                    }
                }
            }
        }

        Console.WriteLine("Кратчайшие расстояния между всеми парами вершин: ");
        Console.WriteLine();

        for (int i = 0; i < V; i++)
        {
            Console.Write("|");
            for (int j = 0; j < V; j++)
            {
                if (dist[i, j] == int.MaxValue)
                    Console.Write("int.MaxValue ");
                else
                    Console.Write(dist[i, j] + "\t");
            }
            Console.Write("|\n");
        }
    }
}
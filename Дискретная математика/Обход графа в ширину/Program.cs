using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int c = 1;
        int v = 8;
        List<int>[] adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }

        adj[0].Add(1);
        adj[0].Add(2);
        adj[0].Add(4);
        adj[1].Add(2);
        adj[1].Add(4);
        adj[2].Add(4);
        adj[3].Add(5);
        adj[3].Add(6);
        adj[3].Add(7);
        adj[5].Add(7);
        adj[6].Add(7);

        bool[] visited = new bool[v];

        for (int i = 0; i < v; i++)
        {

            if (!visited[i])
            {
                Console.WriteLine("Вершины компоненты связности {0}:", c);
                Queue<int> queue = new Queue<int>();
                visited[i] = true;
                queue.Enqueue(i);
                while (queue.Count > 0)
                {
                    int w = queue.Dequeue();
                    Console.Write(w+1 + " ");

                    foreach (int n in adj[w])
                    {
                        if (!visited[n])
                        {
                            visited[n] = true;
                            queue.Enqueue(n);
                        }
                    }
                }
                c++;
                Console.WriteLine();
            }
        }
    }
}

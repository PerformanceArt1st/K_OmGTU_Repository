using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[,] grid = {
            { 0, 0, 0, 0, 0 },
            { 0, 1, 1, 1, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 1, 0, 1, 0 },
            { 0, 0, 0, 1, 0 }
        };

        int rows = 5, cols = 5;
        var directions = new (int, int)[] { (0, 1), (1, 0), (0, -1), (-1, 0) };
        var queue = new Queue<(int, int)>();
        var visited = new bool[rows, cols];
        var parent = new (int, int)?[rows, cols];

        (int startX, int startY) = (0, 0);
        (int endX, int endY) = (4, 4);

        queue.Enqueue((startX, startY));
        visited[startX, startY] = true;

        while (queue.Count > 0)
        {
            var (x, y) = queue.Dequeue();
            if ((x, y) == (endX, endY)) break;

            foreach (var (dx, dy) in directions)
            {
                int nx = x + dx;
                int ny = y + dy;
                if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && grid[nx, ny] == 0 && !visited[nx, ny])
                {
                    queue.Enqueue((nx, ny));
                    visited[nx, ny] = true;
                    parent[nx, ny] = (x, y);
                }
            }
        }
        var path = new List<(int, int)>();
        for (var at = (endX, endY); at != (startX, startY); at = parent[at.Item1, at.Item2].Value)
        {
            path.Add(at);
        }
        path.Add((startX, startY));
        path.Reverse();

        int steps = path.Count - 1;

        Console.Write("Путь:\n[");
        foreach (var point in path)
        {
            Console.Write($" ({point.Item1}, {point.Item2}) ");
        }
        Console.WriteLine($"]\nКоличество шагов: {steps}");
    }
}
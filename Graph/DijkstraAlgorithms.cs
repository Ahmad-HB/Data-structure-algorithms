namespace Graph;

public static class DijkstraAlgorithms
{
    public static Dictionary<T, int> Dijkstra<T>(IGraph<T> graph, T source)
    {
        var distances = new Dictionary<T, int>();
        var priorityQueue = new PriorityQueue<T, int>();
        var visited = new HashSet<T>();

        foreach (var vertex in graph.GetVertices())
        {
            distances[vertex] = int.MaxValue;
        }

        distances[source] = 0;
        priorityQueue.Enqueue(source, 0);

        while (priorityQueue.Count > 0)
        {
            priorityQueue.TryDequeue(out var current, out var _);

            if (visited.Contains(current)) continue;
            visited.Add(current);

            foreach (var (neighbor, weight) in graph.GetAdjacencyList()[current])
            {
                int newDist = distances[current] + weight;
                if (newDist < distances[neighbor])
                {
                    distances[neighbor] = newDist;
                    priorityQueue.Enqueue(neighbor, newDist);
                }
            }
        }

        return distances;
    }
}

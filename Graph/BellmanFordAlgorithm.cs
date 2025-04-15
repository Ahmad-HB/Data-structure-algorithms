namespace Graph;

public static class BellmanFordAlgorithm
{
    public static Dictionary<T, int> BellmanFord<T>(Graph<T> graph, T source, out bool hasNegativeCycle)
    {
        var distances = new Dictionary<T, int>();
        var vertices = graph.GetVertices();
        var edges = graph.GetAllEdges();
        hasNegativeCycle = false;

        foreach (var vertex in vertices)
        {
            distances[vertex] = int.MaxValue;
        }

        distances[source] = 0;

        int vertexCount = distances.Count;

        for (int i = 1; i < vertexCount; i++)
        {
            foreach (var (from, to, weight) in edges)
            {
                if (distances[from] != int.MaxValue && distances[from] + weight < distances[to])
                {
                    distances[to] = distances[from] + weight;
                }
            }
        }

        // Check for negative cycle
        foreach (var (from, to, weight) in edges)
        {
            if (distances[from] != int.MaxValue && distances[from] + weight < distances[to])
            {
                hasNegativeCycle = true;
                break;
            }
        }

        return distances;
    }
}

using System;
using System.Collections.Generic;
namespace Graph;

public class Graph<T> : IGraph<T>
{
    private readonly Dictionary<T, List<(T to, int weight)>> adjacencyList;

    public Graph()
    {
        adjacencyList = new Dictionary<T, List<(T to, int weight)>>();
    }

    public void AddVertex(T vertex)
    {
        if (!adjacencyList.ContainsKey(vertex))
        {
            adjacencyList[vertex] = new List<(T to, int weight)>();
        }
    }

    public void AddEdge(T from, T to, int weight)
    {
        if (!adjacencyList.ContainsKey(from))
            AddVertex(from);

        if (!adjacencyList.ContainsKey(to))
            AddVertex(to);

        adjacencyList[from].Add((to, weight));
    }

    public Dictionary<T, List<(T to, int weight)>> GetAdjacencyList()
    {
        return adjacencyList;
    }

    public bool ContainsVertex(T vertex) => adjacencyList.ContainsKey(vertex);

    public IEnumerable<T> GetVertices() => adjacencyList.Keys;
    
    
    public List<(T from, T to, int weight)> GetAllEdges()
    {
        var edges = new List<(T from, T to, int weight)>();
        foreach (var from in adjacencyList)
        {
            foreach (var (to, weight) in from.Value)
            {
                edges.Add((from.Key, to, weight));
            }
        }
        return edges;
    }
}

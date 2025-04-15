using Graph;

class MyClass
{
    static void Main(string[] args)
    {
        IGraph<string> graph = new Graph<string>();

        graph.AddVertex("A");
        graph.AddVertex("B");
        graph.AddVertex("C");

        graph.AddEdge("A", "B", 4);
        graph.AddEdge("B", "C", 2);
        graph.AddEdge("C", "A", 7); // making it connected

        Console.WriteLine("Graph:");
        foreach (var vertex in graph.GetVertices())
        {
            Console.Write($"{vertex} -> ");
            foreach (var edge in graph.GetAdjacencyList()[vertex])
            {
                Console.Write($"({edge.to}, weight: {edge.weight}) ");
            }
            Console.WriteLine();
        }
        
        
        
        var graph2 = new Graph<string>();
        graph.AddEdge("A", "B", 4);
        graph.AddEdge("A", "C", 2);
        graph.AddEdge("B", "C", 3);
        graph.AddEdge("B", "D", 2);
        graph.AddEdge("C", "B", 1);
        graph.AddEdge("C", "D", 5);
        graph.AddEdge("D", "E", 1);
        graph.AddEdge("E", "A", -10); // for Bellman-Ford only

// Dijkstra
        var dijkstraDistances = DijkstraAlgorithms.Dijkstra(graph, "A");
        Console.WriteLine("Dijkstra:");
        foreach (var (v, d) in dijkstraDistances)
            Console.WriteLine($"{v}: {d}");

// Bellman-Ford
        bool hasNegCycle;
        var bellmanDistances = BellmanFordAlgorithm.BellmanFord(graph2, "A", out hasNegCycle);
        Console.WriteLine("Bellman-Ford:");
        if (hasNegCycle)
            Console.WriteLine("Negative weight cycle detected.");
        else
            foreach (var (v, d) in bellmanDistances)
                Console.WriteLine($"{v}: {d}");
        
        
    }
}
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
        
        
    }
}
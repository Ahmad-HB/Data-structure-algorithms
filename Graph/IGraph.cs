namespace Graph;

public interface IGraph<T> where T : notnull
{
    void AddVertex(T vertex);
    void AddEdge(T from, T to, int weight);
    Dictionary<T, List<(T to, int weight)>> GetAdjacencyList();
    bool ContainsVertex(T vertex);
    IEnumerable<T> GetVertices();

    public List<(T from, T to, int weight)> GetAllEdges();
}

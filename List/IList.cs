namespace List;

public interface IList
{
    void add(int value);
    int get(int value);
    int removeAtIndex(int value);
    int removeLastIndex();
    int size();
    void print();
    void resize();
}
namespace List;

public class List : IList
{
    private int[] Array;
    private int Size;

    public List(int capacity)
    {
        Array = new int[capacity];
        Size = 0;
    }
    
    public void add(int value)
    {
        if (size() == Array.Length)
        {
            resize();
        }

        Array[size()] = value;
        this.Size++;
    }

    public int get(int value)
    {
        return Array[value];
    }

    public int removeAtIndex(int value)
    {
        int removedValue = Array[value];
        if (value< 0 || value >= size())
        {
            Console.WriteLine("Error: Index out of bounds");
            return -1;
        }
        else
        { 
            Array[value]=0;
            for (int i = value; i <Array.Length -1; i++)
            {
                Array[i] = Array[i + 1];
            }
            // Array[size() - 1] = 0;
            // this.Size--;
            return removedValue;
        }
        {
            
        }
    }

    public int removeLastIndex()
    {
        int removedValue = Array[this.Size - 1];
        Array[this.Size - 1] = 0;
        return removedValue;
    }

    public int size()
    {
        return Size;
    }

    public void print()
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Console.WriteLine(Array[i]);
        }
    }

    public void resize()
    {
        int[] newArray = new int[Array.Length * 2];
        for (int i = 0; i < Array.Length; i++)
        {
            newArray[i] = Array[i];
        }

        Array = newArray;
    }
}
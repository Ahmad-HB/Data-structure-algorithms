namespace Algorithms;

public static class LinearSearch
{
    public static int Search(int[] arr, int key)
    {
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == key)
                return i;
        return -1;
    }
}
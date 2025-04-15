using System.Diagnostics;

namespace Algorithms;

class MyClass
{
    static void Main(string[] args)
    {
        const int size = 10000;
        int[] original = GenerateRandomArray(size);

        Console.WriteLine("Sorting Performance (Array Size: " + size + ")\n");

        RunSort("Bubble Sort", BubbleSort.Sort, original);
        RunSort("Selection Sort", SelectionSort.Sort, original);
        RunSort("Insertion Sort", InsertionSort.Sort, original);
        RunSort("Quick Sort", QuickSort.Sort, original);
        RunSort("Merge Sort", MergeSort.Sort, original);

        int key = original[new Random().Next(size)];
        RunSearch("Linear Search", LinearSearch.Search, original, key);
    }

    static int[] GenerateRandomArray(int length)
    {
        Random rand = new Random();
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
            arr[i] = rand.Next(0, 10000); // Random values between 0 and 9999
        return arr;
    }

    static void RunSort(string name, Action<int[]> sortMethod, int[] original)
    {
        int[] copy = (int[])original.Clone();

        Stopwatch stopwatch = Stopwatch.StartNew();
        sortMethod(copy);
        stopwatch.Stop();

        Console.WriteLine($"{name}: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void RunSearch(string name, Func<int[], int, int> searchMethod, int[] arr, int key)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        int index = searchMethod(arr, key);
        stopwatch.Stop();

        Console.WriteLine($"\n{name}: Found {key} at index {index} in {stopwatch.ElapsedMilliseconds} ms");
    }
}
// See https://aka.ms/new-console-template for more information

SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

// union
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);

PrintCollection(c);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}
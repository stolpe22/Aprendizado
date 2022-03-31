// See https://aka.ms/new-console-template for more information

SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

// union
SortedSet<int> c = new SortedSet<int>(a);
//Aqui o conjunto c une-se ao cojunto b, sem repetir os elementos devido à restrição. Logo, o resultado é 0 2 4 5 6 7 8 9 10
c.UnionWith(b);
PrintCollection(c);

//intersection
SortedSet<int> d = new SortedSet<int>(a);
//Retorna apenas os valores em comum nas duas coleções
d.IntersectWith(b);
PrintCollection(d);

//difference
SortedSet<int> e = new SortedSet<int>(a);
//Retorna apenas os valores divergentes entre as duas coleções
e.ExceptWith(b);
PrintCollection(e);

static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T item in collection)
    {
        Console.Write(item+" ");
    }
    Console.WriteLine();
}
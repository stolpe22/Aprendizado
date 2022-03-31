// See https://aka.ms/new-console-template for more information

HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));

foreach (string p in set)
{
    Console.WriteLine(p);
}
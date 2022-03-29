// See https://aka.ms/new-console-template for more information
using List_Set_Generics;

PrintService printService = new PrintService();

Console.Write("How many values? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int x = int.Parse(Console.ReadLine());
    printService.AddValue(x);
}

printService.Print();
Console.WriteLine("First: " + printService.First());
int[] numbers = new int[] { 2, 3, 4, 5 };

//LINQ é composto por vários extensions methods atrelados às coleções
var result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10);

foreach (var x in result)
{
    Console.WriteLine(x);
}
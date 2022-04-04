using Func.Entities;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Tablet", 350.50));
        list.Add(new Product("HD Case", 80.90));

        Func<Product, string> func = p => p.Name.ToUpper(); // func recebe Product e retorna string 
        //Se colocar chaves {}, como no outro exemplo, teria que colocar a palavra return. Porque quando coloca chaves o que a expressão lambda expera é um comando.
        //Mas como a lambda corresponde à uma função que retorna algo, pode-se apagar o return e as chaves

        List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

        foreach(string s in result)
        {
            Console.WriteLine(s);
        }
    }

    static string NameUpper(Product p)
    {
        return p.Name.ToUpper();
    }
}


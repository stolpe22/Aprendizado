using Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

Action<Product> action = p => { p.Price += p.Price * 0.1; }; //recebe o argumento 'p' e chama uma ação. Para a ação abre e fecha chaves para indicar que a fução tem um corpo mas não vai retornar nada. 

list.ForEach(action);

list.ForEach(p => Console.WriteLine(p));

void UpdatePrice (Product product)
{
    product.Price += product.Price * 0.1;
}
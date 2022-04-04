using Action.Entities;

List<Product> list = new List<Product>();

list.Add(new Product("Tv", 900.00));
list.Add(new Product("Mouse", 50.00));
list.Add(new Product("Tablet", 350.50));
list.Add(new Product("HD Case", 80.90));

Action<Product> action = UpdatePrice; //Posso chamar o método na Action

list.ForEach(action);

list.ForEach(p => Console.WriteLine(p));

void UpdatePrice (Product product)
{
    product.Price += product.Price * 0.1;
}
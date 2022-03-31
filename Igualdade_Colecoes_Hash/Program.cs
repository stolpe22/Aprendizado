using Igualdade_Colecoes_Hash.Entities;

//Fundamentos e Conceitos de comparação

//Tipo Referencia
HashSet<Product> products = new HashSet<Product>();
products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 1200.00));

//Tipo Valor
HashSet<Point> points = new HashSet<Point>();
points.Add(new Point(3, 4));
points.Add(new Point(5, 10));

Product product2 = new Product("Notebook", 1200.00);
//GetHashCode e Equals foram implementados na classe Product, a comparação do Contains, agora, retorna FALSE;
Console.WriteLine(products.Contains(product2));
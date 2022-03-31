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

Product product2 = new Product("Nootebook", 1200.00);
//Contains, neste caso, por não ter implementação do GetHashCode e Equals, ele compara a referência de memória e retorna FALSE;
Console.WriteLine(products.Contains(product2));
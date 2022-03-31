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

Product product = new Product("Notebook", 1200.00);
//GetHashCode e Equals foram implementados na classe Product, a comparação do Contains, agora, retorna FALSE;
Console.WriteLine(products.Contains(product));

Point point = new Point(5, 10);
//Neste caso, mesmo não tendo implementado GetHashCode e Equals, Contains retorna TRUE.
//Quando é tipo valor (e.g. struct) os valores são comparados, não os ponteiros na memória.
Console.WriteLine(points.Contains(point));
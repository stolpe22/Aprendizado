// See https://aka.ms/new-console-template for more information
using GetHashCode_Equals.Entities;

Client client = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client client2 = new Client { Name = "Alex", Email = "maria@gmail.com" };

//Os emails são iguais, logo a comparação entre os objetos retornará true;
Console.WriteLine(client.Equals(client2));
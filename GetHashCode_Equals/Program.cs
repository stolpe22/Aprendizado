// See https://aka.ms/new-console-template for more information
using GetHashCode_Equals.Entities;

Client client = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client client2 = new Client { Name = "Alex", Email = "alex@gmail.com" };

//Os emails são diferentes, logo a comparação entre os objetos retornará false;
Console.WriteLine(client.Equals(client2));
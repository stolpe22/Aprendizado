// See https://aka.ms/new-console-template for more information
using GetHashCode_Equals.Entities;

Client client = new Client { Name = "Maria", Email = "maria@gmail.com" };
Client client2 = new Client { Name = "Alex", Email = "maria@gmail.com" };


Console.WriteLine(client.Equals(client2));// Os emails são iguais, logo a comparação Equals() entre os objetos retornará true;
Console.WriteLine(client == client2);// O operador == compara referência do ponteiro de memória do objeto, sendo duas instâncias diferentes, o resultado é false
//GetHashCode obtendo seu valor a partir da propriedade Email, conforme override
Console.WriteLine(client.GetHashCode());
Console.WriteLine(client2.GetHashCode());
//Fundamentos e Conceitos de comparação

HashSet<string> set = new HashSet<string>();

set.Add("Maria");
set.Add("Alex");

//Se GetHashCode e Equals estiverem implementados:
//Primeiro GetHashCode. Se der igual, ele usa Equals para confirmar
//Se GetHashCode e Equals NÃO estiverem implementados:
//Tipos referência: compara as referências dos objetos
//Tipos valor: compara os valores dos atributos
Console.WriteLine(set.Contains("Maria"));
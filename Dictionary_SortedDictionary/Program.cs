Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies["phone"] = "9988776655";
cookies["phone"] = "5544332211";//Este valor sobrescreverá o valor anterior da chave "phone", por não permitir repetições de chave

Console.WriteLine(cookies["phone"]);
Console.WriteLine(cookies["email"]);

cookies.Remove("email");

if (cookies.ContainsKey("email"))
    Console.WriteLine(cookies["email"]);
else
    Console.WriteLine("There is no 'email' key");

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine();

Console.WriteLine("ALL COOKIES:");

foreach(KeyValuePair<string, string> kvp in cookies)
{
    Console.WriteLine(kvp.Key + ": " + kvp.Value);
}

Dictionary<string, string> products = new Dictionary<string, string>()
{
    { "5900000000000", "A1" },
    { "5901111111111", "B5" },
    { "5902222222222", "C9" }
};

// Adicionando um produto
products["5903333333333"] = "D7";

// Tratando chave duplicada
try
{
    products.Add("5904444444444", "A3");
}
catch (ArgumentException)
{
    Console.WriteLine("O produto já existe.");
}

// Exibindo todos os produtos
Console.WriteLine("Todos os produtos:");

if (products.Count == 0)
{
    Console.WriteLine("Nenhum produto cadastrado.");
}
else
{
    foreach (KeyValuePair<string, string> product in products)
    {
        Console.WriteLine($" - {product.Key}: {product.Value}");
    }
}

// Buscando pelo código de barras
Console.WriteLine();
Console.Write("Digite o código de barras: ");

string barcode = Console.ReadLine() ?? "";

if (products.TryGetValue(barcode, out string? location))
{
    Console.WriteLine($"O produto está na área {location}.");
}
else
{
    Console.WriteLine("Produto não encontrado.");
}



using System;
using System.Collections.Generic;

Dictionary<string, Automovel> automoveis = new();

string opcao;

do
{
    Console.WriteLine("\nSISTEMA DE CONTROLE DE AUTOMÓVEIS");
    Console.WriteLine("1 - Cadastrar automóvel");
    Console.WriteLine("2 - Buscar automóvel pela placa");
    Console.WriteLine("3 - Listar todos os automóveis");
    Console.WriteLine("4 - Buscar automóveis por marca");
    Console.WriteLine("5 - Sair");

    Console.Write("\nEscolha uma opção: ");
    opcao = Console.ReadLine() ?? "";

    switch (opcao)
    {
        case "1":
            Console.Write("Digite a placa: ");
            string placa = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (automoveis.ContainsKey(placa))
            {
                Console.WriteLine("Já existe um automóvel com essa placa.");
                break;
            }

            Console.Write("Digite a marca: ");
            string marca = Console.ReadLine() ?? "";

            Console.Write("Digite o modelo: ");
            string modelo = Console.ReadLine() ?? "";

            Console.Write("Digite o ano: ");
            if (!int.TryParse(Console.ReadLine(), out int ano))
            {
                Console.WriteLine("Ano inválido.");
                break;
            }

            Console.Write("Digite a cor: ");
            string cor = Console.ReadLine() ?? "";

            Console.Write("Digite o valor: R$ ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal valor))
            {
                Console.WriteLine("Valor inválido.");
                break;
            }

            automoveis.Add(placa, new Automovel
            {
                Placa = placa,
                Marca = marca,
                Modelo = modelo,
                Ano = ano,
                Cor = cor,
                Valor = valor
            });

            Console.WriteLine("Automóvel cadastrado com sucesso!");
            break;

        case "2":
            Console.Write("Digite a placa: ");
            string placaBusca = (Console.ReadLine() ?? "").Trim().ToUpper();

            if (automoveis.TryGetValue(placaBusca, out Automovel? carro))
            {
                carro.Exibir();
            }
            else
            {
                Console.WriteLine("Automóvel não encontrado.");
            }
            break;

        case "3":
            if (automoveis.Count == 0)
            {
                Console.WriteLine("Nenhum automóvel cadastrado.");
            }
            else
            {
                foreach (Automovel veiculo in automoveis.Values)
                {
                    veiculo.Exibir();
                }
            }
            break;

        case "4":
            Console.Write("Digite a marca: ");
            string marcaBusca = Console.ReadLine() ?? "";
            bool encontrado = false;

            foreach (Automovel veiculo in automoveis.Values)
            {
                if (veiculo.Marca.Equals(marcaBusca,
                    StringComparison.OrdinalIgnoreCase))
                {
                    veiculo.Exibir();
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Nenhum automóvel dessa marca encontrado.");
            }
            break;

        case "5":
            Console.WriteLine("Encerrando o sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

} while (opcao != "5");

class Automovel
{
    public string Placa { get; set; } = "";
    public string Marca { get; set; } = "";
    public string Modelo { get; set; } = "";
    public int Ano { get; set; }
    public string Cor { get; set; } = "";
    public decimal Valor { get; set; }

    public void Exibir()
    {
        Console.WriteLine("\n----------------------");
        Console.WriteLine($"Placa: {Placa}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Cor: {Cor}");
        Console.WriteLine($"Valor: R$ {Valor:N2}");
        Console.WriteLine("----------------------");
    }
}

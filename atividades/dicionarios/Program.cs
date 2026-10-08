
using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    { "Edson Arantes do Nascimento", "0000" },
    { "Ronaldo Nazareo dos Santos", "1111" },
    { "Roberto Carlos Braga", "2222" }
};

// Adicionando em tempo de execução
phoneBook["Acelino Popó de Freitas"] = "3333";

// Tratando possível erro de duplicidade de chave
try
{
    phoneBook.Add("Edson Arantes do Nascimento", "0000");
}
catch (System.ArgumentException ae)
{
    Console.WriteLine("Chave já existe no dicionário. " + ae.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Erro imprevisto. " + ex.Message);
}

// Exibindo o caderninho de telefone
Console.WriteLine("\nCaderninho de telefone:");

if (phoneBook.Count == 0)
{
    Console.WriteLine("Agenda vazia.");
}
else
{
    int i = 1;

    foreach (DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{i} - {entry.Key} : {entry.Value}");
        i++;
    }
}


//Busca em chave
Console.WriteLine("");
Console.WriteLine("Busca por nome: ");
string name = Console.ReadLine();

if (phoneBook.ContainsKey(name))
{
     string number = (string)phoneBook[name];
     Console.WriteLine($"Número de {name}: {number}");
}
else 
{
    Console.WriteLine($"{name} não encontrado.");
}

/*
DICI0NÁRIOS
*/

Dictionary<string, string> dic  =new Dictionary<string, string>()
{
    { " Dom Pedro II", "4545" },
    { "Joaquimm José da Silva Xavier", "121212" },
   
};

// Obtendo valor do dicionário
string value = dic[" Dom Pedro II"];

dic[ "Dom Pedro II"] = "666";

foreach(KeyValuePair<string, string> pair in dic) { Console.WriteLine($"{pair.Key} : {pair.Value}"); }
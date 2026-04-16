using System.Collections.Concurrent;

Console.WriteLine("Classe Array\n");

string[] nomes = {"Victoria", "Raica", "de", "Lima", "Albuquerque" };

Console.WriteLine("Exibindo array orignal...");
Exibir(nomes);

Console.WriteLine("\nExibindo array invertido...");
Array.Reverse(nomes);
Exibir(nomes);

Console.WriteLine("\nExibindo array ordenado...");
Array.Sort(nomes);
Exibir(nomes);

Console.WriteLine("\nInforme um nome: ");
var nome = Console.ReadLine();

var indice = Array.BinarySearch(nomes, nome);
if (indice >= 0)
    Console.WriteLine($"\nO {nome} foi encontrado com indice: {indice}");
else
    Console.WriteLine($"\nO {nome} foi não encontrado");

    Console.ReadKey();
static void Exibir(string[] nomes)
{
    foreach (string s in nomes)
    {
        Console.WriteLine($"{s}");
    }
}

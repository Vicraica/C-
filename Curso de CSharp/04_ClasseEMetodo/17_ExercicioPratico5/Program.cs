using Microsoft.VisualBasic;

Console.WriteLine("Praticando...");

Info info = new();
info.ExibirInfo(Modelo: "Gol", Montadora: "Volkswagen", Marca: "Carro", Potencia: "100cv");
info.ExibirInfo(Marca: "Carro", Montadora: "Volkswagen", Potencia: "100cv", Ano: "2012", Modelo: "Gol");


Console.ReadKey();

public class Info
{
    public void ExibirInfo(string Modelo, string Montadora, string Marca, string Potencia, string Ano = "Ano Padrão")
    {
        Console.WriteLine($"{Modelo} | {Montadora} | {Marca} | {Potencia} | {Ano}");
    }
}

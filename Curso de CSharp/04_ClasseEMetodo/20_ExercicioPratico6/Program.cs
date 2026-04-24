Console.WriteLine("Praticando...");

Info info = new();
info.ExibirInfo(Modelo: "Gol", Montadora: "Volkswagen", Marca: "Carro", Potencia: "100cv");
info.ExibirInfo(Marca: "Carro", Montadora: "Volkswagen", Potencia: "100cv", Ano: "2012", Modelo: "Gol");
info.ObterValorIPVA();


Console.ReadKey();

public class Info
{
    public static double ValorIpva = 4;

    public void ExibirInfo(string Modelo, string Montadora, string Marca, string Potencia, string Ano = "Ano Padrão")
    {
        Console.WriteLine($"{Modelo} | {Montadora} | {Marca} | {Potencia} | {Ano}");
    }

    public void ObterValorIPVA ()
    {
        Console.WriteLine($"O valor do IPVA do carro é de {ValorIpva}%");
    }
}




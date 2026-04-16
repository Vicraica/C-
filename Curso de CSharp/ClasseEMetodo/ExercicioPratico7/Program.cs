Console.WriteLine("Praticando...");

Info info = new();
info.ExibirInfo(Modelo: "Gol", Montadora: "Volkswagen", Marca: "Carro", Potencia: "100cv");
info.ExibirInfo(Marca: "Carro", Montadora: "Volkswagen", Potencia: "100cv", Modelo: "Gol");
info.Ano = 2015;
Console.WriteLine($"Ano do carro ajustado: {info.Ano}");
info.ObterValorIPVA();


Console.ReadKey();

public class Info
{
    public static double ValorIpva = 4;

    private int ano;
    public int Ano 
    { 
        get{ return ano; }
        set  
        {   if (value < 2012)
                ano = 2012;
            else if (value > 2022)
                ano = 2022;
            else
                ano = value;
        }
    }


    public void ExibirInfo(string Modelo, string Montadora, string Marca, string Potencia)
    {
        Console.WriteLine($"{Modelo} | {Montadora} | {Marca} | {Potencia}");
    }

    public void ObterValorIPVA()
    {
        Console.WriteLine($"O valor do IPVA do carro é de {ValorIpva}%");
    }
}

Console.WriteLine("Praticando...");

Console.WriteLine($"{Cores.Branco} - {(int)Cores.Branco}");
Console.WriteLine($"{Cores.Vermelho} - {(int)Cores.Vermelho}");
Console.WriteLine($"{Cores.Preto} - {(int)Cores.Preto}");
Console.WriteLine($"{Cores.Cinza} - {(int)Cores.Cinza}");
Console.WriteLine($"{Cores.Prata} - {(int)Cores.Prata}");
Console.WriteLine($"{Cores.Azul} - {(int)Cores.Azul}");

Console.WriteLine("Escolha uma das opçoes de cor indicando a numeração correspondente: ");
int cor = Convert.ToInt32(Console.ReadLine());

Carro info = new();
info.Cor = cor;
info.ExibirInfo(Modelo: "Gol", Montadora: "Volkswagen", Marca: "Carro", Potencia: "100cv", info.Cor);
info.ObterValorIPVA();

Console.ReadKey();

public enum Cores
{
    Branco = 1,
    Vermelho,
    Preto,
    Cinza,
    Prata,
    Azul
}
public class Carro
{
    public static double ValorIpva = 4;
    public int Cor;
    public void ExibirInfo(string Modelo, string Montadora, string Marca, string Potencia,int Cor,string Ano = "Ano Padrão")
    {
        Console.WriteLine($"{Modelo} | {Montadora} | {Marca} | {Potencia}| {(Cores)Cor} | {Ano}");
    }
    public void ObterValorIPVA()
    {
        Console.WriteLine($"O valor do IPVA do carro é de {ValorIpva}%");
    }
}
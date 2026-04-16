public class Pessoa
{
    public static int IdadeMinima;

    public int Idade { get; set; }
    public string Nome { get; set; } = string.Empty; 


    public Pessoa(int idade, string nome)
    {
        Console.WriteLine("Inicializando construtor parametrizado.");
        Idade = idade;
        Nome = nome;
    }

    static Pessoa()
    {
        Console.WriteLine("Inicializando construtor estático");
        Console.WriteLine("Idade mínima...");
        IdadeMinima = 18;
    }
}


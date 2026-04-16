Console.WriteLine("Exercício 4\n");

Potencia pot = new();
int p = pot.AumentarPotenciaVelocidade(10, out double v);

Console.WriteLine($"Nova Potencia: {p}");
Console.WriteLine($"Nova Velocidade: {v}");


Console.ReadKey();

public class Potencia
{
    public int AumentarPotenciaVelocidade (int potencia, out double velocidade)
    {
        int Novapotencia = potencia + 7;
        velocidade = Novapotencia * 1.75;
        return Novapotencia;

        Console.WriteLine($"{Novapotencia}");
        Console.WriteLine($"{velocidade}");
    }
    
}

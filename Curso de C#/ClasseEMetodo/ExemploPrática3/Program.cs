Console.WriteLine("Exercício 3\n");

Potencia pot = new();
int p = pot.AumentarPotencia(5);
int q = 5;
q = pot.AumentarPotencia(ref q);
Console.WriteLine($"{p}");
Console.WriteLine($"{q}");

Console.ReadKey();

public class Potencia
{
    public int AumentarPotencia(int potencia)
    {
        int NovaPotencia = potencia + 3;
        return NovaPotencia;
    }
    public int AumentarPotencia(ref int potencia)
    {
        int NovaPotencia = potencia + 5;
        return NovaPotencia;
    }
}

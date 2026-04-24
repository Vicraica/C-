Console.WriteLine("Campos Estáticos\n");

ContaCorrente c1 = new();
c1.Conta = 5214;
c1.Nome = "Rosa";
c1.JurosAnual();

ContaCorrente c2 = new();
c2.Conta = 8741;
c2.Nome = "Carlos";
c2.JurosAnual();

ContaCorrente.Juros = 4.99f;

Console.WriteLine($"Nome: {c1.Nome} | JurosAnual: {c1.JurosAnual()}");
Console.WriteLine($"Nome: {c2.Nome} | JurosAnual: {c2.JurosAnual()}");


Console.ReadKey();

public class ContaCorrente
{
    public int Conta;
    public string? Nome;
    public static float Juros;

    public float JurosAnual()
    {
        return Juros * 12;
    }
}

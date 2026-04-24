using System.Diagnostics.Contracts;

Console.WriteLine("This");

Teste t1 = new Teste();
t1.num1 = 15;
t1.num2 = 81;
t1.Exibir();

Teste t2 = new Teste();
t2.num1 = 19;
t2.num2 = 23;
t2.Exibir();

Console.ReadKey();

public class Teste
{
    public int num1;
    public int num2; 

    public void PassarParametro(Teste t)
    {
        Console.WriteLine($"\nthis = {this}");
        Console.WriteLine($"num1 = {num1}");
        Console.WriteLine($"num2 = {num2}");
    }
    public void Exibir ()
    {
        PassarParametro(this);
    }
}

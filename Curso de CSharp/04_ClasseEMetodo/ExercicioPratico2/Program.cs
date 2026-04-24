using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Exercício prático 2!\n");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
Console.WriteLine($"{chevrolet.modelo}, {chevrolet.montadora}, {chevrolet.marca}, {chevrolet.ano}, {chevrolet.potencia}");
double vel = chevrolet.VelocidadeMaxima(chevrolet.potencia);
Console.WriteLine($"{chevrolet.modelo} - Velocidade máxima: {vel}\n");
chevrolet.Acelerar();

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
Console.WriteLine($"{ford.modelo}, {ford.montadora}, {ford.marca}, {ford.ano}, {ford.potencia}");
double vel1 = ford.VelocidadeMaxima(ford.potencia);
Console.WriteLine($"{ford.modelo} - Velocidade máxima: {vel1}\n");
ford.Acelerar();


Console.ReadKey();


public class Carro
{
    public string? modelo;
    public string? montadora;
    public string? marca;
    public int ano;
    public int potencia;

    public Carro(string modelo, string montadora, string marca, int ano, int potencia)
    {
        this.modelo = modelo;
        this.montadora = montadora;
        this.marca = marca;
        this.ano = ano;
        this.potencia = potencia;
     }

    public Carro(string Modelo, string Montadora)
    {
        modelo = Modelo;
        montadora = Montadora;
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }
    public void Acelerar()
    {
        Console.WriteLine($"Acelerando{marca}\n");
    }

}

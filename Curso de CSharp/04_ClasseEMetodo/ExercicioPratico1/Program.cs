using System.Globalization;
using System.Net.Http.Headers;

Console.WriteLine("Exercicio prático 1\n");

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);
chevrolet.Acelerar();

Console.WriteLine($"{chevrolet.modelo}, {chevrolet.montadora}, {chevrolet.marca}, {chevrolet.ano}, {chevrolet.potencia}\n");

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);
ford.Acelerar();

Console.WriteLine($"{ford.modelo}, {ford.montadora}, {ford.marca}, {ford.ano}, {ford.potencia}");


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

    public void Acelerar()
    {
        Console.WriteLine($"Acelerando{marca}\n");
    }

}

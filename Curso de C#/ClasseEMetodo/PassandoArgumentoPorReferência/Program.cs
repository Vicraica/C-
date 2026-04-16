Console.WriteLine("Passando Argumento Por Valor\n");
int x = 10;
Console.WriteLine("Valor da variável x antes de chamar o método Dobro: " + x); // Exibir o valor original de x

Calculo calc = new();
calc.Dobro(ref x); // Envia o endereço de x na memória para o método Dobro, permitindo que ele modifique o valor original.
Console.WriteLine($"\nO valor da váriavel x depois de passar pelo método dobrar {x} ");


Console.ReadKey();

public class Calculo
{
    public void Dobro(ref int y) // método que recebe o endereço de x e atribui a y, permitindo que y modifique o valor original de x.
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar = " + y); // Exibir o valor de y dentro do método   
    }
}

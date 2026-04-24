Console.WriteLine("Passando Argumento Por Valor\n");
int x = 10;
Console.WriteLine("Valor da variável x antes de chamar o método Dobro: " + x); // Exibir o valor original de x

Calculo calc = new();
calc.Dobro(x); // Chama o método dobro para dobrar o valor de x.
Console.WriteLine($"O valor da váriavel x depois de passar pelo método dobrar {x} \n");


Console.ReadKey();

public class Calculo
{
    public void Dobro(int y) // método que recebe o valor de x e atribui a y, ou seja, y é uma cópia de x e executa a operação de dobrar.
    {
        y *= 2;
        Console.WriteLine("\nValor do parâmetro y no método Dobrar = " + y); // Exibir o valor de y dentro do método   
    }
}

Console.WriteLine("Métodos Estáticos\n");

int Somar = Calculadora.Somar(15, 8); // Ao definir os métodos como estáticos, não é necessário instanciar um objeto para utilizá-los.
int Subtrair = Calculadora.Subtrair(1, 8); // Apenas chamar a classe seguida do método.
int Multiplicar = Calculadora.Multiplicar(3, 8);
int Dividir = Calculadora.Dividir(25, 5);

Console.WriteLine(Somar);
Console.WriteLine(Subtrair);
Console.WriteLine(Multiplicar);
Console.WriteLine(Dividir);

Console.ReadKey();  

public class Calculadora
{
    public static int Somar(int a, int b)
    {
        return a + b;
    }
    public static int Subtrair(int a, int b)
    {
        return a - b;
    }
    public static int Multiplicar(int a, int b)
    {
        return a * b;
    }
    public static int Dividir (int a, int b)
    {
        return a / b;
    }
}
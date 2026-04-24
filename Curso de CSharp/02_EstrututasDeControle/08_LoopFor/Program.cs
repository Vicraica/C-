Console.WriteLine("Loop For");

int numero, resultado;

Console.WriteLine("Digite um número inteiro para ver sua tabuada:");
numero = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=10; i++)
{
    resultado = numero * i;
    Console.WriteLine($"{numero} X {i} = {resultado}");

}
Console.WriteLine("\nFim do processamento...");
Console.ReadKey();





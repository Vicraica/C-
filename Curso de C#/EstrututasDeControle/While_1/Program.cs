Console.WriteLine("Estrura While");

var i = 10;

while(i > 0)
{
    Console.WriteLine($"i = {i}");
    i --;
    
}

var x = 1;

while (x <= 10)
{
    Console.WriteLine($"x = {x}");
    i++;

} 

Console.WriteLine($"Tabuada");
int num;
int contador = 1;

Console.WriteLine("\nDigite um número maior que zero:");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    while (contador < 11)
    {
        Console.WriteLine($"{num} x {contador} = {num * contador}");
        contador++;
    }

}
else
{
       Console.WriteLine("Número inválido!");
}

    Console.WriteLine("\nFim do programa...");
Console.ReadKey();
Console.WriteLine("Estrutura While 2");
int num;
while (true)
{
    Console.WriteLine("\nInforme um número inteiro: (Tecle 999 para sair.)");
    num = Convert.ToInt32(Console.ReadLine());
    if (num == 999)
    {
        break;
    }

    if (num % 2 == 0)
    {
        Console.WriteLine($"{num} é PAR");
    }
    else
    {
        Console.WriteLine($"{num} é ÍMPAR");
    }
} 

//Coordenadas (x,y)
int x = 0;
while(x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y})");
        y++;
    }
    x++;
    Console.WriteLine();
}


Console.WriteLine("\nFim do procesamento...");
Console.ReadKey();
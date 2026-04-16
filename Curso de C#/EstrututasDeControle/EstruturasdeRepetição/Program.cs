Console.WriteLine("Estruturas de repetição");

int i = 1;

repetir: // label

Console.WriteLine($"i = {i}");

i++; // sem o incremento, o loop seria infinito

if (i <= 10)
    goto repetir;   

Console.WriteLine("Fim do programa.");
Console.ReadKey();
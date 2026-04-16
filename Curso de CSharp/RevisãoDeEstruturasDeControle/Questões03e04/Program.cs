Console.WriteLine("Questões 03 e 04");

// Questão 03
//int x = 1, soma = 0;

//Console.WriteLine("Os 10 primeiros números naturais são: ");

//while (x<=10)
//{
//    soma += x;
//    x++;
//    Console.Write($" {x} ");
//}
//Console.WriteLine($"A soma é: {soma}");


// Questão 04

while (true)
{
    Console.WriteLine("\nDigite um valor para a tabuada (ou 999 para sair): ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == 999)
    { break; }

    if (num > 0)
    {
        Console.WriteLine($"\nTabuada do {num}:");
        for (int contador = 1; contador <= 10; contador++)
        {
            int multi = num * contador;
            Console.WriteLine($"{num} x {contador} = {multi}");
        }
    }
    else
    {
        Console.WriteLine("O valor deve ser maior que zero!");
    }
}
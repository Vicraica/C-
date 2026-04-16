Console.WriteLine("Aprendendo o bloco try catch\n");

Console.WriteLine("Digite o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

try // Executa a ação a ser avaliada se têm erros.
{
    int Div = (x) / (y);

    Console.WriteLine($"O resultado da divisão: {x}/{y} = {Div}");
}
catch (Exception ex) // Executa se houver erros.
{
    Console.WriteLine("Não existe divisão por 0.\n");
    Console.WriteLine($"Error: <<<{ex.Message} >>>\n");
    Console.WriteLine($"Detalhes: {ex.StackTrace.ToString()}\n");
}
finally // Excuta independemnete de a ver erro ou não.
{
    Console.WriteLine("Fim do processamento...");
}
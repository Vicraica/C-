Console.WriteLine("Estrutura Do While\n");

int i = 0;
do
{
    Console.WriteLine($"i = {i}");
    i++;

    if(i > 7){
        break;
    }

} while (i <= 10);



int x = 0;
do
{
    int y = 0;
    do
    {
        Console.Write($"({x},{y}) ");
        y++;
    } while (y < 5);
    x++;
    Console.WriteLine(); 

} while (x < 5);


Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

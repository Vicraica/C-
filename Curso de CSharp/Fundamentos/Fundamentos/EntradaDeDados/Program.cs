Console.WriteLine("Entrada de Dados");

Console.WriteLine("Digite o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine()); // O ReadLine lê string, logo, é necessário a conversão.

Console.WriteLine("Digite a cidade em que mora:");
string cidade = Console.ReadLine();

Console.WriteLine($"\n O seu nome é {nome}.");
Console.WriteLine($"\n A sua idade é {idade} anos.");
Console.WriteLine($"\n Você mora na cidade de {cidade}.");

/* Não se usa o Console.Read() para o propósito de armazenar dados, pois ele lê
 apenas um caractere e retorna o código ASCII do caractere lido. */
Console.WriteLine("Digite a primeira letra do seu nome:");
char letra = (char)Console.Read();
Console.WriteLine($"A primeira letra do seu nome é {letra}.");



Console.ReadKey();
// O Console.ReadKey() mantém a janela do console aberta até que uma tecla seja pressionada.




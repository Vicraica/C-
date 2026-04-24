Console.WriteLine("Estrutura Switch\n");

int compra = 1000;
Console.WriteLine("Valor da compra: R$ 1.000,00");
Console.WriteLine("Informe o valor da parcela(1 a 3): ");
int parcela = Convert.ToInt32(Console.ReadLine());

switch (parcela)
{
    case 1:
        Console.WriteLine($"Valor da parcela:R${compra/parcela}");
        break;
    case 2:
        Console.WriteLine($"Valor da parcela:R${compra / parcela}");
        break;
    case 3:
        Console.WriteLine($"Valor da parcela:R${compra / parcela}");
        break;
    default:
        Console.WriteLine("Número de parcelas inválido!");
        break;
}

Console.WriteLine("Digite um valor: \n");
int valor = Convert.ToInt32(Console.ReadLine());

switch (valor%2)
{
    case 0:
        Console.WriteLine($"{valor} é par.");
        break;
    case 1:
        Console.WriteLine($"{valor} é ímpar.");
        break;

} 

Console.WriteLine("Digite um mês: ");
string mes = Console.ReadLine().ToLower();

switch (mes) {
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Mês com 31 dias.");
        break;

    case "fevereiro":
        Console.WriteLine("Mês com 28 ou 29 dias.");
        break;
    default:
    Console.WriteLine("Mês com 30 dias");
        break;
}

int cargo = 0;
int funcao = 0;

Console.WriteLine("Qual o seu cargo? Gerente(1) e Programador(2)\n");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junio(1) ou Senior(2)?");
    funcao = Convert.ToInt32(Console.ReadLine());
}
switch (cargo)
{
    case 1:
        Console.WriteLine("Bem-Vindo Gerente!");
        break;
    case 2:
        Console.WriteLine("Bem-Vindo Programador!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("Você é junior.");
                break;
            case 2:
                Console.WriteLine("Você é Senior.");
                break;
            default:
                Console.WriteLine("Função desconhecida");
                break;
        break;
        } 
        break;
default:
    Console.WriteLine("Não conseguimos te identificar");
    break;
}

























Console.WriteLine("Fim do processamento...");
Console.ReadKey();
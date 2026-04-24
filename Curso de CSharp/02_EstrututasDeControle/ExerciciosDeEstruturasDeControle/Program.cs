using System.Runtime.Serialization;

Console.WriteLine("Exercícios\n");

//Questão 1 
Console.WriteLine("Digite um número");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um número");
int numero3 = Convert.ToInt32(Console.ReadLine());

if (numero1 >= numero2 && numero1>=numero3)
{
    Console.WriteLine($"O {numero1} é o maior número da sequência.");
}
else if (numero2 >= numero1 && numero2 >= numero3)
{
    Console.WriteLine($"O {numero2} é o maior número da sequência.");
}
else
{
    Console.WriteLine($"O {numero3} é o maior número da sequência!");
} 

//Questão 2
Console.WriteLine("Cálculo da equação do segundo grau (ax^2+bx+c) :");

Console.WriteLine("Digite o valor de a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de c:");
int c = Convert.ToInt32(Console.ReadLine());

double delta = Math.Pow(b, 2) - 4 * a * c;

if (delta < 0)
{
    Console.WriteLine("As raízes são imaginárias");
    Console.WriteLine("Sem solução para os números reais");
}
else if (delta == 0)
{
    int resultado1 = -b / (2 * a);
    Console.WriteLine("As raízes são iguais");
    Console.WriteLine($"A única raiz é: {resultado1}");
}
if (delta > 0)
{
    double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine("Ambas as raízes são reais e diferentes");
    Console.WriteLine($"Primeira raiz X1= {raiz1}");
    Console.WriteLine($"Segunda raiz X2= {raiz2}"); 
}

//Questão 3 
Console.WriteLine("O exemplo com While");
Console.WriteLine("Os 10 primeiros número naturais são:");
int x = 1;
int soma = 0;
while (x <= 10)
{
    Console.Write($" {x}");
    soma += x;
    x++;
}
Console.WriteLine("\nA soma dos números é : " + soma + "\n");

Console.WriteLine("O exemplo com While");
Console.WriteLine("Os 10 primeiros número naturais são:");
int y = 1;
int somaDoWhile = 0;
do {
    Console.Write($" {y}");
    somaDoWhile += y;
    y++;
} while (y <= 10);
Console.WriteLine("\nA soma dos números é : " + somaDoWhile + "\n");

Console.WriteLine("O exemplo com For");
Console.WriteLine("Os 10 primeiros número naturais são:");
int z;
int somaDoFor = 0;
for (z = 1; z <=10; z++ )
{
    Console.Write($" {z}");
    somaDoFor += z;
    
} while (z <= 10);
Console.WriteLine("\nA soma dos números é : " + somaDoFor + "\n");

//Questão 4 

int contador;
while(true)
{   
    Console.WriteLine("Digite um valor maior que 0(para sair tecle 999)\n");
    int w = Convert.ToInt32(Console.ReadLine());

    if (x == 999){
        Console.WriteLine("Fim do processamento.");
        break;
    }
    else if(w > 0)
    {
        contador = 1;
        while (contador < 11)
        { 
            Console.WriteLine($"{w} X {contador} = {w * contador}\n");
            contador++;
        }
    }
    else
    {
        Console.WriteLine("Você deve digitar um número maior que 0");
    }

}
Console.ReadKey(); 

//Questão 5 
Console.WriteLine("Qual a instrução para sair de um loop?");
Console.WriteLine("a.quit");
Console.WriteLine("b.continue");
Console.WriteLine("c.break");
Console.WriteLine("d.exit \n\n");
Console.WriteLine("Qual a opção correta? (Tecle x para sair)");
string resposta = Console.ReadLine().ToLower();


if (resposta == "a" || resposta == "b" || resposta == "d")
{
    Console.WriteLine("Resposta incorreta");
}
else if (resposta == "c")
{
    Console.WriteLine("Resposta correta!");
}
else if (resposta == "x")
{
    Console.WriteLine("Fim do processamento...");
}
else
{
    Console.WriteLine("resposta inválida");
}
Console.ReadKey(); 

//Questão 6 

for(int d = 10; d <= 20; d +=2)
{
    if (d != 16)
    Console.WriteLine(d);
}

Console.WriteLine();

for (int e = 10; e <= 20; e ++)
{
    if (e % 2 == 0 && e != 16)
        Console.WriteLine(e);
}

Console.WriteLine();
int t = 10;
while(true)
{
    if (t > 20) { break; }
    if(t == 16)
    {
        t++;
        continue;
    }
    if (t % 2 == 0)
    {
        Console.WriteLine(t);
    }
    t++;
} 

//Questão 7 
int i, j, linhas;

Console.WriteLine("Informe o número de linhas: ");
linhas = Convert.ToInt32(Console.ReadLine());

for (i = linhas; i == 1; i--)
{
    for(j = linhas; j == 1; j--)
    {
        Console.Write("*");
    }
    Console.Write("\n");
}



//Questão 8 

int f = 1;
Console.WriteLine("Digite o número para calcular o fatorial: ");
int n = Convert.ToInt32(Console.ReadLine());

for(int q = 1; q <= n; q++)
{
    f = f * q;
}
Console.WriteLine($"O fatorial de {n} é {f}");

//Questão 9 
int numero = 1;
do
{
    int multi = 1;
    do
    {
        Console.WriteLine($"{numero} x {multi} = {numero * multi} ");
        multi++;
    } while (multi <= 10);
    Console.WriteLine();
    numero++;
} while (numero <= 10);

//Questão 10 
while (true)
{
    Console.WriteLine("Informe a nota do aluno(tecle 99 se deseja sair)\n");
    int s = Convert.ToInt32(Console.ReadLine());

    if (s == 99)
        {Console.WriteLine("Fim do processamento..."); break; }

    Console.WriteLine("Resultado da avalição: \n");
    switch (s)
    {
        case 10:
            Console.WriteLine("A+");
            break;
        case 9:
            Console.WriteLine("A");
            break;
        case 8:
        case 7:
            Console.WriteLine("B");
            break;
        case 6:
            Console.WriteLine("C");
            break;
        case 5:
            Console.WriteLine("E");
            break;
        default:
            Console.WriteLine("F");
            break;
    }
}

//Questão 11
// Variáveis declaradas e inicializadas
int numero_1;
int numero_2;
string operando;
float respost = 0; 

Console.Write("\nInforme o primeiro número: \t");
numero_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("\nInforme o operando (+, -, /, *): ");
operando = Console.ReadLine();

Console.Write("\nInforme o segundo número: \t");
numero_2 = Convert.ToInt32(Console.ReadLine());

switch (operando)
{
    case "-":
        respost = numero_1 - numero_2;
        break;
    case "+":
        respost = numero_1 + numero_2;
        break;
    case "/":
        respost = (float)numero_1 / numero_2;
        break;
    case "*":
        respost = numero_1 * numero_2;
        break;
    default:
        Console.WriteLine("Operador inválido.");
        break;
} 

Console.WriteLine("O resultado é: " + respost);
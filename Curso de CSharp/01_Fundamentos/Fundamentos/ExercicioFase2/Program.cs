using System.Runtime.InteropServices;

/*Console.WriteLine("Exercício fase 2 de C#");

var nome = "Paulo";
var idade = 17;
var nota = 7.5;

Console.WriteLine($"ALuno {nome} tem {idade} anos e nota {nota}");
Console.WriteLine($"{nome}\n{idade}\n{nota}\n");

// float converte implicitamente para double, pois os dois tem 8 bytes.

// decimal para float e long para int precisa de conversão explícita.

Console.WriteLine("Digite uma letra: ");
string letra1 = Console.ReadLine();

Console.WriteLine("Digite uma letra: ");
string letra2 = Console.ReadLine();

Console.WriteLine("Digite uma letra: ");
string letra3 = Console.ReadLine();

Console.WriteLine($"As letras digitadas foram: {letra3}, {letra2}, {letra1}");
Console.WriteLine("As letras digitada foram: "+ letra3 + "," + letra2 + ","+ letra1 + "\n");

// V, V, F, V, F, V, V, V.

Console.WriteLine("Digite um valor: ");
double Valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Valor1);

Console.WriteLine("Digite um valor: ");
double Valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(Valor2);

Console.WriteLine($"Soma: {Valor1 + Valor2}");
Console.WriteLine($"Subtração: {Valor1 - Valor2}");
Console.WriteLine($"Multiplicação: {Valor1 * Valor2}");
Console.WriteLine($"Exponenciação de {Valor1}:: {Math.Exp(Valor1)}");
Console.WriteLine($"Exponenciação de {Valor2}: {Math.Exp(Valor2)}");
Console.WriteLine($"Divisão: {Valor1 / Valor2}");
Console.WriteLine($"Módulo: {Valor1 % Valor2}\n"); 

Console.WriteLine("Fórmula de Baskaras");
int a = 1, b= 12, c= -13;

double delta = Math.Pow(b,2) - 4 * a * c;
double raizDelta = Math.Sqrt(delta);
double x = ((-b + raizDelta) / (2*a));
double y = ((-b - raizDelta) / (2*a));

Console.WriteLine($"O valor de x1 é: {x}");
Console.WriteLine($"O valor de x2 é: {y}\n"); 

Console.WriteLine("Digite o seu login: ");
string login = Console.ReadLine();

Console.WriteLine("Digite a sua uma senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

var resultado = ((login == "admin" || login == "maria") && senha == 123)
    ? "Login feito com sucesso!"
    : "Login inválido" ;

Console.WriteLine(resultado); 


// V, V, F, V, F, F, F, ? ,V, V, V

Console.WriteLine("Digite um valor: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um valor: ");
int y = Convert.ToInt32(Console.ReadLine());

var resultadox = (x % 2 == 0) ? "número par" : "número ímpar";
var resultadoy = (y % 2 == 0) ? "número par" : "número ímpar";

Console.WriteLine($"O {x} é um {resultadox}.");
Console.WriteLine($"O {y} é um {resultadoy}."); 

Console.WriteLine("Digite um valor: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(-6 + a * 5);
Console.WriteLine((13-2)*a);
Console.WriteLine((a + -2)*(20/a));
Console.WriteLine((12 + a)*(a - 4));
Console.WriteLine(Math.Pow(3,2) + a +10);
Console.WriteLine(Math.PI * Math.Pow(a,2));

/*int y = 5;
int resultado_y = (y++) + y + (++y);
Console.WriteLine(y); */

/*Console.WriteLine("Digite a temperatuda em grau Celsius: ");
double tempC = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(tempC + "°");

double K = tempC + 273;
double F = (tempC * 9 / 5) + 32;

Console.WriteLine($"Em Kelvin: {K}");
Console.WriteLine($"Em Farhenheit: {F}");*/




Console.ReadKey(); 
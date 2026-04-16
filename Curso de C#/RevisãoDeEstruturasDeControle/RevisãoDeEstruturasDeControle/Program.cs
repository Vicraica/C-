Console.WriteLine("Revisão: questões 01 e 02\n");

Console.WriteLine("Digite um valor para o primeiro número: ");
int PrimeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um valor para o segundo número: ");
int SegundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite um valor para o terceiro número: ");
int TerceiroNumero = Convert.ToInt32(Console.ReadLine());

if (PrimeiroNumero > SegundoNumero && PrimeiroNumero > TerceiroNumero)
{
    Console.WriteLine($"O primeiro número:{PrimeiroNumero} é o maior.");
}
else if(SegundoNumero > PrimeiroNumero && SegundoNumero > TerceiroNumero)
{
    Console.WriteLine($"O segundo número:{SegundoNumero} é o maior.");
}
else
{
    Console.WriteLine($"O terceiro número:{TerceiroNumero} é o maior.");
} 

// Questão 02

int a, b, c;
double delta;

Console.WriteLine("Declare o valor de a:");
a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Declare o valor de b:");
b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Declare o valor de c:");
c = Convert.ToInt32(Console.ReadLine());

delta = Math.Pow(b, 2) - 4 * a * c  ;

if(delta > 0)
{
    Console.WriteLine("Ambas as raízes são reais e diferentes.");
    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"Primeira raiz x1= {x1}");
    Console.WriteLine($"Primeira raiz x2= {x2}");
}
else if (delta == 0 )
{
    Console.WriteLine("Há apenas uma raiz real.");
    double x = -b / (2 * a);
    Console.WriteLine($"O valor de X1 e X2 é {x}");
}
else
{
    Console.WriteLine("As raízes são imaginárias.\nSem solução para os números reais.");
}


Console.ReadKey();


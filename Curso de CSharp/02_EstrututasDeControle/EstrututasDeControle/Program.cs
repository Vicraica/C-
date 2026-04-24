Console.WriteLine("Estrutura de controle IF\n");

Console.WriteLine("Você é um cliente especial? (S/N)\t");
string clienteEspecial = Console.ReadLine();
if (clienteEspecial=="S") 
{
    Console.WriteLine("Desconto de 10%");
};

Console.ReadKey();

Console.WriteLine("Você é um cliente especial? (true/false)");
bool clienteEspecial_1 = Convert.ToBoolean(Console.ReadLine());
if (clienteEspecial_1)
{
    Console.WriteLine("Desconto de 10%");
} 

Console.WriteLine("Digite o valor de X ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de Y \t");
int y = Convert.ToInt32(Console.ReadLine());

if (x>y)

    Console.WriteLine("X é maior que Y");

if (x<y)

    Console.WriteLine("X é menor que Y");

if (x==y)

    Console.WriteLine("X é igual a Y");


Console.ReadKey();
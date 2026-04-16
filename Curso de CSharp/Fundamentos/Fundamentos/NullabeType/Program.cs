Console.WriteLine("Nullable Types");
Console.WriteLine();

Nullable<int> x = null; //forma explicita
int? y = null; //forma implicita
Console.WriteLine(x);
Console.WriteLine(y);

Nullable<double> z = null;
double? w = null;
Console.WriteLine(z);
Console.WriteLine(w);

Nullable<char> a = null;
char? b = null;
Console.WriteLine(a);
Console.WriteLine(b);

// os tipos de dados de valor não podem receber o valor null diretamente
// int numero = null; // isso gera erro de compilação   

// os nullable types além de receber o valor null, também podem receber valores do seu tipo base. 
// Porém o inverso não é verdadeiro, ou seja, os tipos base não podem receber null.

int? c = null;
int d = c ?? 0; // operador de coalescência nula, que retorna zero se c for null e o valor de c caso contrário.
Console.WriteLine(b);

//int? e = 10;
//int f = 2;
//int g = e * f; 
//nesse caso há problema pois todos os valores ser null ou todos devem ser int para realizar a operação.

int? e = 10;
int? f = 2;
int? g = e * f;
Console.WriteLine(g);

Console.WriteLine();
Console.WriteLine("Propriedades de leitura dos Nullable Types:hasvalue e value");
int? n = 100;
if(n.HasValue)
{
    Console.WriteLine($"n = {n.Value}");
}
else
{
    Console.WriteLine("n não possui valor(null)");
}


Console.ReadKey();
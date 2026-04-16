using System.Formats.Asn1;

Console.WriteLine("Declarando Constantes:");

const int MESES_ANO = 12;
const int DIAS_ANO = 365;

const float DIAS_MES = (float)DIAS_ANO / (float)MESES_ANO;

Console.WriteLine( $"O valor de dias por mês é= {DIAS_MES} \n");

// Calcular área e perímetro de um círculo
// área = π * r²
// perímetro = 2 * π * r

const double PI = 3.14;
Console.WriteLine($"Digite o valor do raio do círculo: \n");
double r = Convert.ToDouble(Console.ReadLine());

var area = PI * r;
var perimetro = 2 * PI * r;
Console.WriteLine(area);
Console.WriteLine(perimetro);

Console.ReadKey();
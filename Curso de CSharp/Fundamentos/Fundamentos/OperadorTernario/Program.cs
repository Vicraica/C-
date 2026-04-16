Console.WriteLine("Operadores Ternários");

Console.WriteLine("Informe um número positivo: ");
var n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"O positivo de {-n} é {+n}");
var resultado = n >= 0 ? "Número positivo" : "Número negativo";
Console.WriteLine(resultado);
Console.WriteLine("\n");

Console.WriteLine("Informe a temperatura: ");
var temp = Convert.ToInt32(Console.ReadLine());

var resultadoTemp = temp >= 27 ? "Está quente!" :
                    temp <= 18 ? "Está frio!" 
                    : "Está ameno!";

Console.WriteLine($"O tempo esta {resultadoTemp}");
Console.ReadKey();
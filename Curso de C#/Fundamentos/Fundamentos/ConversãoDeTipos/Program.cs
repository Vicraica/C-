Console.WriteLine("Conversão de tipos\n");

// Conversão implícita: conversão que é feita automaticamente entre tipos de variaveis compatíveis com relação aos bytes. 
/* Short - 2 bytes
   Int - 4 bytes
   Float - 4 bytes
   Double - 8 bytes
   Long - 8 bytes
   Decimal - 16 bytes*/

int numeroInt = 250;
double numeroDouble = numeroInt;
float numeroFloat = numeroInt;
long numeroLong = numeroInt;

Console.WriteLine(numeroDouble);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroLong);
// A conversão do int acontece porque ele tem apenas 4 bytes e logo é suportado por estes tipos.
// obs: o inverso jamais pode acontecer, ou seja, converter double, float ou long para int.

/* Conversão explícita: conversão que deve ser feita manualmente, através de casting,
 quando há perda de informação ou quando os tipos não são compatíveis, porém haverá perda de precisão das informações.*/

double valordouble = 142.45823;
int valorInt = (int)valordouble; // casting = 142
float valorFloat = (float)valordouble; // casting = 142,45824
Console.WriteLine(valorInt);
Console.WriteLine(valorFloat);

int num1 = 10;
int num2 = 4;
double resultado = num1 / num2; // 2 .5 esperado, mas o resultado é 2, pois ambos são inteiros.
Console.WriteLine(resultado);

// Para corrigir, é necessário fazer o casting de um dos valores para double ou float.
double resultadoCorreto = (double)num1 / num2; // 2.5
Console.WriteLine(resultadoCorreto);

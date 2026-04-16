Console.WriteLine("Conversão de Tipos");

int numInt = 105;
double numDouble = 15.56;
bool numBool = false;
string numString = "Vic";

Console.WriteLine(Convert.ToString(numInt)); // 105
Console.WriteLine(Convert.ToDouble(numInt)); // 105 
Console.WriteLine(Convert.ToString(numBool)); // False
Console.WriteLine(Convert.ToInt32(numDouble)); // 16
Console.WriteLine(Convert.ToChar(numString)); // exemplo de conversão inválida que gera exceção.


Console.WriteLine("Operadores Lógicos");

bool a = 5 >= 10;
bool b = 8 != 10;
bool resultado;
Console.WriteLine($"O valor de a é: {a}");
Console.WriteLine($"O valor de b é: {b}\n");

resultado = a && b;
Console.WriteLine($"Operador E (&&) {resultado}");

resultado = a || b;
Console.WriteLine($"Operador OU (||) {resultado}");

resultado = !a;
resultado = !b;
Console.WriteLine($"Operador de Negação (!) a: {resultado}");
Console.WriteLine($"Operador de Negação (!) b: {resultado}");

Console.ReadKey();
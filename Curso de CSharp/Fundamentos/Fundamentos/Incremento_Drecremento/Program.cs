Console.WriteLine("Operadores de Incremento e Decremento");

int x = 0;
Console.WriteLine($"x = {x}");

// Pós-incremento: primeiro resolve a expressão e depois incrementa o valor da variável.
int result1 = x++ + 10; // result1 = 0 + 10; x = 1

Console.WriteLine($"Pós-incremeto: {result1}");
Console.WriteLine($"O valor de x é {x}\n");

int y = 0;
Console.WriteLine($"y = {y}");

// Pré-incremento: primeiro incrementa o valor da variável e depois resolve a expressão.
int result2 = ++y + 10;

Console.WriteLine($"Pré-incremeto: {result2}"); // result2 = 1 + 10; y = 1
Console.WriteLine($"O valor de y é {y}\n");

Console.WriteLine("------------------------------------------------------\n");
int a = 0;
Console.WriteLine($"a = {a}");

// Pós-decremento: primeiro resolve a expressão e depois decrementa o valor da variável.
int result3 = a-- + 10;

Console.WriteLine($"Pós-decremeto: {result3}"); // result3 = 0 + 10; a = -1
Console.WriteLine($"O valor de a é {a}\n");

int b = 0;
Console.WriteLine($"b = {b}");

// Pré-decremento: primeiro decrementa o valor da variável e depois resolve a expressão.
int result4 = --b + 10;

Console.WriteLine($"Pré-decremeto: {result4}"); // result4 = -1 + 10; b = -1
Console.WriteLine($"O valor de b é {b}\n");


Console.ReadKey();
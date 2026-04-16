Console.WriteLine("Precedência e Associatividade\n");

int a = 10 - 2 * 3;
Console.WriteLine($"{a}\n");

int b = (10 - 2) * 3;
Console.WriteLine($"{b}\n");

int x = 5, y = 6 ,z = 4;
int resultado = ++x * y - --z;
Console.WriteLine($"{resultado}\n");

int x1 = 5, y1 = 6, z1 = 4;
int resultado1 = ++x1 * (y1 - --z1);
Console.WriteLine($"{resultado1}\n");

int c = 5, d = 6, e = 4;
int resultado2 = c = d = e;
Console.WriteLine($"{resultado2}\n");

Console.ReadKey();



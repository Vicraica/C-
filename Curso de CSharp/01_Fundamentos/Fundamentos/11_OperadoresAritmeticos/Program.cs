Console.WriteLine("Operações matemáticas");

Console.WriteLine("\nDigite o valor de x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o valor de y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO valor da soma entre x e y é: {x + y}");
Console.WriteLine($"O valor da subtração entre x e y é: {x - y}");
Console.WriteLine($"O valor da multiplicação entre x e y é: {x * y}");
double divisão = (double)x / y;
Console.WriteLine($"O valor da divisão entre x e y é: {divisão}");
Console.WriteLine($"O valor do resto da divisão entre x e y é: {x%y}");

Console.WriteLine("Classe Math");

Console.WriteLine("\nDigite o valor de w: ");
int w = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nDigite o valor de z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nO valor da raiz quadrade de w é ={Math.Sqrt(w)}");
Console.WriteLine($"O valor da raiz quadrade de z é ={Math.Sqrt(z)}");
Console.WriteLine($"O valor da potência de w elevado a z = {Math.Pow(w,z)}");
Console.WriteLine($"O valor mínimo entre w e z é: {Math.Min(w,z)}");
Console.WriteLine($"O valor máximo entre w e z é: {Math.Max(w,z)}");
Console.WriteLine($"O valor do cosseno de w é = {Math.Cos(w)}");
Console.WriteLine($"O valor do seno de z é = {Math.Sin(z)}");
Console.WriteLine($"O valor da exponeciação de w é = {Math.Exp(w)}");
Console.WriteLine($"O valor da exponeciação de z é = {Math.Exp(z)}");


Console.ReadKey();


Console.WriteLine("Tipos de Saídas de Dados");

int idade = 19; 
string nome = "Victória";
double altura = 1.66;

Console.WriteLine();
Console.WriteLine("________CONCATENAÇÃO_______________");
Console.WriteLine(nome + " tem " + idade + " anos e " + altura + " de altura.");

Console.WriteLine();
Console.WriteLine("________INTERPOLAÇÃO_______________");
Console.WriteLine($"{nome} tem {idade} anos e {altura} de altura");

Console.WriteLine();
Console.WriteLine("________PLACE HOLDER_______________");
Console.WriteLine("{0} tem {1} anos e {2} de altura", nome, idade, altura);

Console.ReadLine();

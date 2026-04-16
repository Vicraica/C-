// O nullable reference types serve para indicar que uma variável de referência pode aceitar valores nulos
// ,ajudando a evitar erros de referência nula em tempo de execução.

string a = null; // Aviso de compilação: possível atribuição de valor nulo a uma variável não anulável
string? b = null; // Variável anulável, pode aceitar valores nulos sem avisos de compilação
Console.WriteLine($"Valor de a: {a}"); // Isso pode causar um erro em tempo de execução se 'a' for usado sem verificação
Console.WriteLine($"Valor de b: {b}"); // Isso é seguro, pois 'b' é uma variável anulável
Console.ReadKey();

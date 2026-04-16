Console.WriteLine("Construtor estático\n");

Pessoa p1 = new(20, "Ana");
Console.WriteLine($"{p1.Nome} - {p1.Idade}");
Console.WriteLine($"Idade mínima: {Pessoa.IdadeMinima}\n");

Pessoa p2 = new(17, "Sergio");
Console.WriteLine($"{p2.Nome } - {p2.Idade}");
Console.WriteLine($"Idade mínima: {Pessoa.IdadeMinima}\n");

Console.ReadKey();


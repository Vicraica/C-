Console.WriteLine("Classe e Objeto");

//Objeto
Pessoa p1 = new Pessoa();
p1.nome = "Victoria";
p1.idade = 19;
p1.sexo = "F";

Console.WriteLine($"{p1.nome}  {p1.idade} { p1.sexo}");

Pessoa p2 = new Pessoa();
p2.nome = "Victor";
p2.idade = 23;
p2.sexo = "M";

Console.WriteLine($"{p2.nome} {p2.idade} {p2.sexo}");

Console.ReadKey();
/* A classe deve ser declarada após o fim do corpo do código. 
 A classe serve como modelo para a criação dos objetos(características) e dos métodos(ações).*/
class Pessoa 
{
    public string? nome;
    public int idade;
    public string? sexo;
}
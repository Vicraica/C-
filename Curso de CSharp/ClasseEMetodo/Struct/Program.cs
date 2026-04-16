Console.WriteLine("Aprendendo Struct...\n");

Pessoa pessoa = new Pessoa("Victoria", 18);

Console.ReadKey();

public struct Pessoa //O struct funciona como uma classe, mas tudo é público por padrão.
                     //Se você não escrever nada, qualquer parte do código pode ler ou alterar as variáveis.
{
    public string? Nome;
    public int Idade;

    public Pessoa(string? nome, int idade){
        Nome = nome;
        Idade = idade;

        Console.WriteLine($"{nome} - {idade}");
     }


}
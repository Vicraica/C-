using System.Globalization;

Console.WriteLine("Passando parâmetros");

var aluno = new Aluno();
aluno.Consultar();

Console.ReadKey();

public class Aluno // O objeto 'aluno' criado la em cima é responsável por atribuir os valores pedidos nessa classe.
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovação;

    public void Consultar()
    {
        var aluno = new Aluno();

        Console.WriteLine("Qual o nome do aluno?");
        aluno.nome = Console.ReadLine();

        Console.WriteLine("Qual a idade?");
        aluno.idade = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Qual o sexo do aluno?");
        aluno.sexo = Console.ReadLine();

        Console.WriteLine("Qual a situação de aprovação do aluno? S- aprovado; N-Reprovado");
        aluno.aprovação = Console.ReadLine();

        var aprovacao = new Aprovacao();
        aprovacao.Resultado(aluno);
    }
}

public class Aprovacao
{
    public void Resultado(Aluno aluno) {

        Console.WriteLine($"O aluno {aluno.nome} de {aluno.idade} anos, sexo: {aluno.sexo}."); 
        if (aluno.aprovação == "S")
        {
            Console.WriteLine("\n Aluno aprovado.");
        }
        else
        {
            Console.WriteLine("\n Aluno reprovado.");
        }
    }
} // O objeto 'aprovacao' criado la em cima é responsável por atribuir os valores impressos neste método.
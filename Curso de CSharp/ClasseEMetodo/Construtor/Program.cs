Console.WriteLine("Construtor");

var aluno = new Aluno("Victoria", 19, "Feminino", "S"); 
Console.WriteLine(aluno.nome ==  null ? "nulo" : aluno.nome);
Console.WriteLine(aluno.idade == 0 ? "zero" : aluno.idade);
Console.WriteLine(aluno.sexo == null ? "nulo" : aluno.sexo);
Console.WriteLine(aluno.aprovação == null ? "nulo" : aluno.aprovação);

Console.ReadKey();

public class Aluno 
{
    public string? nome;
    public int idade;
    public string? sexo;
    public string? aprovação;
    public Aluno(string Nome, int Idade, string Sexo, string Aprovação)
    {
        nome = Nome;
        idade = Idade;
        sexo = Sexo;
        aprovação = Aprovação;
    }
}
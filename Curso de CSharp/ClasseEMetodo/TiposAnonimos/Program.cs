Console.WriteLine("Aprendendo os tipos anônimos... \n");


var aluno = new //Essa é a sintaxe da declaração de um tipo anônimo, é um tipo de leitura de dados apenas.
{ 
    Nome = "Victoria",
    Idade = 19
};

Console.WriteLine(aluno.GetType().ToString());
Console.WriteLine(aluno.Nome + " " + aluno.Idade);
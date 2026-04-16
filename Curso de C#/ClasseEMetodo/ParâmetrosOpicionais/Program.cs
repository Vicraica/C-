Console.WriteLine("Parâmetros Obrigatórios \n");

Console.WriteLine("Digite o destino");
string destino = Console.ReadLine();

Console.WriteLine("Digite o titulo");
string titulo = Console.ReadLine();

Console.WriteLine("Digite o assunto");
string assunto = Console.ReadLine();

Email email = new();
email.EnviarEmail();
email.EnviarEmail(destino);
email.EnviarEmail(destino, titulo);
email.EnviarEmail(destino, titulo, assunto);


Console.ReadKey();

public class Email
{
    public void EnviarEmail(string destino = "destino padrão", string titulo = "titulo padrão", string assunto = "assunto padrão")
    {
        Console.WriteLine($"Para {destino} - {titulo} \n assunto: {assunto}\n");
    }
    public void EmailEnviar(string destino, string titulo = "titulo padrão", string assunto = "")
    {
        Console.WriteLine($"Para {destino} - {titulo} \n assunto: {assunto}\n");
    }
}
/*O argumentos opicionais têm os seus valores padrões atribuidos anteriormente e tem que sempre vir após os argumentos que 
 são obrigatórios.*/
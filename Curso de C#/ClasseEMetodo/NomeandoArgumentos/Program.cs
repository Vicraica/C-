Console.WriteLine("Argumentos nomeados");

email enviaremail = new();
enviaremail.Enviar("Suprimentos", "Reunião de alinhamento", "Urgente");
//Se faz necessário passar os valores dos argumentos na ordem pois não utiliza nomeação.

enviaremail.Enviar(assunto: "Urgente", destino: "Suprimentos", titulo: "Reunião de alinhamento");
//Não é necessário seguir a ordem do argumento passado no método da classe se utilizar a nomeação.



Console.ReadKey();

public class  email
{ 
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"Para {destino} - {titulo} \n assunto: {assunto}");
    }

}

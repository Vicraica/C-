Console.WriteLine("Metódos\n");

minhaclasse1 MyCLass = new(); //objeto
MyCLass.saudacao("Victoria", DateTime.Now.ToShortDateString());
Console.ReadKey();

public class minhaclasse1 //classe
{
    public void saudacao(string nome, string data) //método
    {
        Console.WriteLine(nome);
        Console.WriteLine(data);
    }
}
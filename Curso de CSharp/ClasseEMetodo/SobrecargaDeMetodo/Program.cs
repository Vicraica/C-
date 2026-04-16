using System.Globalization;

Console.WriteLine("Sobrecarga de Metodo");

Email email = new();
email.enviar("Empresa.com");
email.enviar("Empresa.com", "Proposta");
email.enviar("Empresa.com", 1520);
email.enviar(1579,"Empresa.com");


Console.ReadKey();

public class Email
{
    public void enviar(string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Assunto Padrão\n");
    }
    public void enviar(string endereco, string assunto)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine($"{assunto}\n");
        
    }
    public void enviar(string endereco, int valor)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Proposta comercial\n");
        Console.WriteLine($"{valor}");
    }
    public void enviar(int valor ,string endereco)
    {
        Console.WriteLine($"{endereco}");
        Console.WriteLine("Pagamento de fornecedor\n");
        Console.WriteLine($"{valor}");
    }
}

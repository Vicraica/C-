using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

Console.WriteLine("Aprendendo... \n ");
Cliente cliente = new("Victoria", "Victoria@gmail.com", 17);
Cliente.ExibirInfo(idade: cliente.Idade, nome: cliente.Nome, email: cliente.Email);
Console.WriteLine("\nNão informando a idade dessa vez...");
Cliente.ExibirInfo(nome: cliente.Nome, email: cliente.Email);
Console.ReadKey();

public struct Cliente
{
    public string Nome;
    public string Email;

    private int idade;
    public int Idade 
    {  
        get { return idade;}
        set
        {
            if (value < 18) 
            { 
                 idade = 18;
                 Console.WriteLine("Cliente menor de idade.");
            }
            else 
            {   
                Console.WriteLine("Cliente maior de idade.");
                idade = value;
            }
        }
    }
    public Cliente(string nome, string email, int idade)
    {
        Nome = nome;   
        Email = email;
        Idade = idade;
    }
    public static void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"Nome: {nome}\nEmail: {email}\nEmail: {idade}");
    }
}


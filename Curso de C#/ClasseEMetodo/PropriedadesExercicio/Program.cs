using System.ComponentModel.DataAnnotations;

Console.WriteLine("Aprendendo sobre Propriedades...\n");

Mercado produto = new Mercado();
produto.Nome = "Arroz";
produto.Preco = 20.00;
// produto.desconto = 0.3; // Não é possível alterar, pois não existe o set.
//produto.PrecoFinal = produto.Preco - (produto.Preco * produto.Desconto);
produto.EstoqueMinimo = 50;

produto.Exibir();

Console.ReadKey();

public class Mercado
{
    private string? nome; // Campo privado para a propriedade Nome.
    public string? Nome 
    { 
        get{ return nome.ToUpper(); } // Acessador get que vai retornar o valor do campo nome em maiúsculas.
        set {nome = value; } // Modificador set que vai atribuir o valor ao campo nome.
    }
    private double preco;
    public double Preco 
    { 
        get{return preco; } // Acessador get que retorna o valor do campo preco.
        set
        {if (value < 5) // Validação simples no set.
                preco = 5;
            else
                preco = value;
        }
    }
    private double desconto = 0.1; // Campo privado com valor padrão de 10%.
    public double Desconto 
    { 
        get { return desconto; } // Acessador get que retorna o valor do campo desconto.
    }
    public double PrecoFinal 
    { 
        get { return Preco - (Preco * Desconto); } // Acessador get que calcula o preço final com desconto.
    }
    public int EstoqueMinimo { get; set; } // Propriedade autoimplementada.

    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}\nPreço: {Preco}\nDeconto: {Desconto}\nPreço final: {PrecoFinal}\nEstoque minímo: {EstoqueMinimo}");
    }
    


}

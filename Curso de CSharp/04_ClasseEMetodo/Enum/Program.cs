Console.WriteLine("Aprendendo sobre Enum... \n");

Console.WriteLine($"{Categorias.Moda} - {(int)Categorias.Moda}");
Console.WriteLine($"{Categorias.Filmes} - {(int)Categorias.Filmes}");
Console.WriteLine($"{Categorias.Tech} - {(int)Categorias.Tech}");
Console.WriteLine($"{Categorias.Livros} - {(int)Categorias.Livros}");
Console.WriteLine($"{Categorias.Life_style} - {(int)Categorias.Life_style}");

Console.WriteLine("Selecione a categoria de acordo com a numeração exibida:");
int valor = Convert.ToInt32(Console.ReadLine());

var escolha = (Categorias)valor;
Console.WriteLine($"\nVocê selecionou a categoria: {escolha.ToString()}");

Console.ReadKey();

enum Categorias
{
    Moda,
    Filmes,
    Tech,
    Livros,
    Life_style,
}
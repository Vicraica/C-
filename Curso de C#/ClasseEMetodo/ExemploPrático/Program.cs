// --- PARTE 1: EXECUÇÃO (O fluxo principal) ---

Console.WriteLine("## Métodos  ##\n");

// Instancia a classe Cadastro (cria a "ferramenta" que sabe registrar e exibir)
Cadastro cadastro = new();

// Chamada do 1º método Registrar:
// Ele não recebe nada nos parênteses, então o C# executa a versão que cria a "Maria"
var cliente = cadastro.Registrar();

// Chamada do 1º método ExibirDados:
// Passamos apenas o objeto 'cliente'. Ele vai mostrar Nome, Idade e Renda.
cadastro.ExibirDados(cliente);

// ALTERAÇÃO DE RENDA:
// Chamada do 2º método Registrar (SOBRECARGA):
// Note que agora passamos o objeto 'cliente' dentro dos parênteses.
// O C# percebe isso e executa a versão que muda a renda para 3500.
cliente = cadastro.Registrar(cliente);

// Chamada do 2º método ExibirDados (SOBRECARGA):
// Passamos um texto e o objeto. O C# usa a versão que formata com o título.
cadastro.ExibirDados("Renda alterada", cliente);

Console.ReadKey();

// --- PARTE 2: O MODELO DE DADOS (A planta da casa) ---

public class Cliente
{
    // Campos (Variáveis que guardam as características do cliente)
    public string? Nome;
    public int Idade;
    public decimal Renda;

    // CONSTRUTOR 1: Usado para criar um cliente já com dados preenchidos
    public Cliente(string? nome, int idade, decimal renda)
    {
        Nome = nome;
        Idade = idade;
        Renda = renda;
    }

    // CONSTRUTOR 2: Construtor vazio (permite criar o objeto sem dados iniciais)
    // Isso é necessário porque, ao criar o construtor acima, o C# apaga o padrão.
    public Cliente()
    { }
}

// --- PARTE 3: A LÓGICA (As engrenagens) ---

public class Cadastro
{
    // MÉTODO REGISTRAR (Versão A): Não recebe parâmetros
    // Utilidade: Criar um registro padrão do zero.
    public Cliente Registrar()
    {
        // Cria um novo objeto Cliente usando o Construtor 1
        Cliente cliente = new("Maria", 23, 3000);
        return cliente; // Devolve a "Maria" para quem chamou o método
    }

    // MÉTODO REGISTRAR (Versão B): Recebe um objeto Cliente existente
    // Utilidade: Atualizar ou editar dados de um cliente que já existe.
    public Cliente Registrar(Cliente cliente)
    {
        cliente.Renda = 3500; // Altera a propriedade Renda do objeto recebido
        return cliente;       // Devolve o mesmo objeto, mas agora com a renda nova
    }

    // MÉTODO EXIBIRDADOS (Versão A): Recebe apenas o cliente
    public void ExibirDados(Cliente cliente)
    {
        // "c" formata o número como Moeda (Currency) ex: R$ 3.000,00
        Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
    }

    // MÉTODO EXIBIRDADOS (Versão B): Recebe um texto extra e o cliente
    public void ExibirDados(string texto, Cliente cliente)
    {
        // \n pula linha | \t dá um espaço de TAB (parágrafo)
        Console.Write($"\n{texto}\t");
        Console.Write($" {cliente.Nome} {cliente.Renda.ToString("c")}");
    }
}
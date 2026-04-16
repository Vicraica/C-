Console.WriteLine("Métodos");

MinhaClasse p = new MinhaClasse();
p.saudacao();

Console.ReadKey();

class MinhaClasse
{
    public void saudacao()
    {
        Console.WriteLine("Seja Bem-Vinda!");
        data();
    }
    public void data() => Console.WriteLine(DateTime.Now.ToShortDateString()); 
    //metodos com uma ação podem ser declarados por meio do "=>", mas também por meio das "{}".

}
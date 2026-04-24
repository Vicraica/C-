using System.Text;

Console.WriteLine("Atribuindo valores as variáveis de referência: String, Object e Dynamic");

Console.WriteLine();
Console.WriteLine("Este é o tipo string");
string nome = "Victória";
Console.WriteLine(nome);

/* O tipo string é imutável, logo sempre que precisar realizar uma mudança de valor a tribuido a variavel do tipo string,
ele criará outro espaço na memória para guardar o novo valor e não subtituir.*/
//Quando se precisa realizar mudanças recorrentes em uma string a melhor opção é 'stringbuilder', porém ele é uma classe e não uma viriável.

Console.WriteLine();
Console.WriteLine("Este é o tipo Object");
object nome1 = "Raica";
object idade = 19;
object altura = 1.66;
object letra = 'V';
object letra2 = '\u0042';

Console.WriteLine(nome1);
Console.WriteLine(idade);
Console.WriteLine(altura);
Console.WriteLine(letra);
Console.WriteLine(letra2);

Console.WriteLine();
Console.WriteLine("Este é o tipo Dynamic");
dynamic nome2 = "De Lima";
dynamic idade2 = 20;
dynamic altura2 = 1.70;
dynamic letra3 = 'D';
dynamic letra4 = '\u0044';

Console.WriteLine(nome2);
Console.WriteLine(idade2);
Console.WriteLine(altura2);
Console.WriteLine(letra3);
Console.WriteLine(letra4);

/* Os tipos object e dynamic são bem parecidos e suportam todos os tipos de dados pois object é a base das variáveis.
A diferença é o tempo da verificação: o object é checado pelo compilador (exige cast), enquanto o dynamic só é
checado na execução (ignora o compilador).*/

Console.ReadLine();
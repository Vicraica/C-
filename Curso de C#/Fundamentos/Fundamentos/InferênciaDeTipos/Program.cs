Console.WriteLine("Inferência do tipo VAR \n");

var idade = 19;
var nome = "Victoria";
var altura = 1.66;

Console.WriteLine($"{nome} tem {idade} anos e {altura} de altura.");
// O var infere o tipo da variável a partir do valor atribuído a ela.

/*Casos que não podem acontecer: 
 var idade; (Variavel não inicializada)
 var idade, nome, altura; (várias variáveis para um var)
 var altura = null;
 
 var idade = 19; 
 idade = "Victoria"; (mudança de tipo)
 */

Console.ReadKey();
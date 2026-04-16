using System.Data;

int idade = 35;
Console.WriteLine(idade);

string nome = "Maria";
Console.WriteLine(nome);

double altura = 3.45;
Console.WriteLine(altura);

DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data);

const int ANO = 12;
Console.WriteLine(ANO);

double? nota = 7.80;
Console.WriteLine(nota);

// Questão 07 : Quais as diferenças entre os tipos por valor e os tipos por referência ?
// Tipo de Valor: Cada variável tem sua própria cópia do dado.
// Tipo de Referência: Várias variáveis podem apontar para o mesmo dado na memória.
// O tipo de valor fica armazenado na memória stack(que é limitada e menos flexível). 
// O objeto real do tipo de referência fica armazenado na memória heap(que é mais flexível e maior que a stack) e o endereço desse objeto fica na memória stack.

int x = 10;
double numero = 7.99;
char letra = 'C';
float temperatura = 27.4f;
bool ativo = false;
string nome1 = "Manoel";
decimal salario = 950.99m;
DateTime hoje = DateTime.Now;

// Questão 09: 
int n = 1; // tipo por valor
string titulo = "A vida";// tipo de referência
float f = 12.45f; // tipo por valor
double d = 5.45; // tipo por valor
decimal valor = 10.99m; // tipo por valor
char sexo = 'M'; // tipo de valor
object o = null; // tipo de referência

//Questão 10 O que é um nullable type e qual a sua utilidade ?
// É um tipo que atribui o valor nulo a variaveis, pois as variaveis do tipo valor não podem receber o valor nulo.

// Questão 11 O que é Camel Case ? Dê um exemplo de sua aplicação.
// É uma convenção de nomenclatura que utiliza o padrão de as primeira letra minúcula enquato as primeiras letras das demais palavras devem ser maiúsculas.
// Sua aplicação se dá em nome de variáveis e campos privados.

// Questão 12 O que é Pascal Case ? Dê um exemplo de sua aplicação
// É uma convenção de nomenclatura que utiliza o padrão de as primeira letra de todas as palavras serem maiúsculas.
// Sua aplicação se dá em nome de classes, campos públicos e etc...

int x1= 66;
int y1 = 77;
Console.WriteLine(x1+y1);

/* Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string?
 bool =  false
 char = \0 
 int = 0
 double = 0
 float = 0
 decimal = 0
 string = null

/* 15- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis
considerando a nomenclatura usada:
(F) double 1valor = 12.45;
(F) string #nome = "Pedro";
(V) float _temperatura = 12.45f;
(F) double int = 5;
(F) decimal renda extra = 91.45m;
(F) bool status$conta = false;
(V) string titulo3 = “Tópico 1”;
(V) float salario_mensal = 1999.55f;
(V) int percentualValorDesconto = 5;
(V) const bool MENSALIDADE_EM_DIA = true; */

Console.ReadLine();


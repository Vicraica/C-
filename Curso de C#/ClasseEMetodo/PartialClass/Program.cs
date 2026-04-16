// See https://aka.ms/new-console-template for more information
using PartialClass;

Console.WriteLine("Partial Class\n");

MyPartialClass minhaPartialClass = new MyPartialClass(); 
// O partial serve para unir as partes de uma classe que foi dividida em arquivos diferentes, contanto que tenha o mesmo nome.

Console.WriteLine("Idade para nascidos em: 18/03/2006\n ");

var idade = minhaPartialClass.CalcularIdade(new DateTime(2006, 3, 18));
Console.WriteLine($"{Math.Round(idade.TotalDays / 365)} anos\n");

Console.WriteLine("Idade para nascidos em: 09/11/1971\n");

var data1 = DateTime.Now;
var data2 = new DateTime(1971,11,9);
var diferenca = minhaPartialClass.DiferencaEntreDatas(data1, data2);
Console.WriteLine($"{Math.Round(diferenca.TotalDays / 365)} anos");


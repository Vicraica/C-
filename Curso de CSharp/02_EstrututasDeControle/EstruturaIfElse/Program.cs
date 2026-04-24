Console.WriteLine("Estrutura If Else");

/*Console.WriteLine("Digite sua nota: ");
double nota = Convert.ToDouble(Console.ReadLine());

if(nota > 5)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
} 

//aninhamento de if else

Console.WriteLine("Digite o valor de x ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite o valor de y ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X é maior que Y");
}
else if (x < y)
{
    Console.WriteLine("X é menor que Y");
}
else
{
    Console.WriteLine("X é igual a Y");
}
*/


Console.WriteLine("Digite a nota do aluno: \t");
double nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado");
}
else 
{
    Console.WriteLine("Aluno aprovado com distinção");
}

Console.WriteLine("Fim do processamento...");

Console.ReadKey();
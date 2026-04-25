// See https://aka.ms/new-console-template for more information
Console.WriteLine("Array + foreach \n");

string[] letras = new string[5] { "A", "B", "C", "D", "E" };

foreach (var L in letras)
{
    Console.WriteLine(L);
}
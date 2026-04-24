using System.Xml;

Console.WriteLine("Struct DateTime \n");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

Console.WriteLine();
Console.WriteLine("Data Específica");
DateTime dataHoje = new DateTime(2025,12,31);
Console.WriteLine(dataHoje);

Console.WriteLine();    
Console.WriteLine("Hora Específica");
DateTime dataHoraHoje = new DateTime(2025,12,31, 23,59,00);
Console.WriteLine(dataHoraHoje);

DateTime hoje = DateTime.Now;

Console.WriteLine();
Console.WriteLine("Extraindo informações da data e hora atual");
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

Console.WriteLine();
Console.WriteLine("Adicionando valores a data e hora atual");
Console.WriteLine(hoje.AddDays(2));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(10));
Console.WriteLine(hoje.AddYears(2));

Console.WriteLine();
Console.WriteLine("Obtendo o dia da semana e do ano");
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

Console.WriteLine();
Console.WriteLine("data e hora no formato longo e curto");
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();


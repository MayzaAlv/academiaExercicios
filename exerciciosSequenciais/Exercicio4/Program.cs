/* 4) Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA
 * e imprima na forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos
 * em variáveis diferentes. */

Console.WriteLine("Exercício 4: Faça um programa em C# e no Visual Studio que receba a data" +
    " na forma DDMMAAAA e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano " +
    "devem ser lidos em variáveis diferentes.\n");

string dia;
string mes;
string ano;

Console.Write("Insira o dia que nasceu: ");
dia = Console.ReadLine();

Console.Write("Insira o mês que nasceu: ");
mes = Console.ReadLine();

Console.Write("Insira o ano que nasceu: ");
ano = Console.ReadLine();   

Console.WriteLine("DD/MM/AAAA: " + dia + "/" + mes + "/" + ano);
Console.WriteLine("AAAA/MM/DD: " + ano + "/" + mes + "/" + dia);
Console.WriteLine("AA/MM/DD: " + (ano % 100) + "/" + mes + "/" + dia);

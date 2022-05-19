/* 18. Elaborar um programa que apresente o valor de uma potência de uma base qualquer 
elevada a um expoente qualquer, ou seja, NM. */

Random rdn = new Random();

int basePotencia = rdn.Next(100);
int expoente = rdn.Next(100);

Console.WriteLine($"{basePotencia} elevado a {expoente} é igual {Math.Pow(basePotencia, expoente)}");
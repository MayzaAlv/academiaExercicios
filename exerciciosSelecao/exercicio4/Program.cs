/* 4 - Escrever um algoritmo para ler a quantidade de horas aula dadas
 * por dois professores e o valor por hora recebido por cada um deles. 
 * Mostrar na tela qual dos professores tem o maior salário total. */

double horas1, horas2;

Console.Write("Insira a quantidade de horas dadas pelo primeiro professor: ");
horas1 = double.Parse(Console.ReadLine());

Console.Write("Insira a quantidade de horas dadas pelo segundo professor: ");
horas2 = double.Parse(Console.ReadLine());

if (horas1 > horas2)
{
    Console.WriteLine("O primeiro professor tem o maior salário.");
}
else if (horas2 > horas1)
{
    Console.WriteLine("O segundo professor tem o maior salário.");
}
else {
    Console.WriteLine("O professores tem o mesmo salário.");
}

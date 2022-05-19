/* 11) Escreva um algoritmo para ler o número de eleitores de um município, 
 * o número de votos brancos, nulos e válidos. Calcule e escreva o percentual
 * que cada um representa em relação ao total de eleitores. */

Console.WriteLine("Exercicio 11: Escreva um algoritmo para ler o número de eleitores de um município, " +
    "o número de votos brancos, nulos e válidos. Calcule e escreva o percentual que cada um " +
    "representa em relação ao total de eleitores.\n");

int eleitores;
double votos_brancos, votos_nulos, votos_validos, votos_totais;

Console.Write("Insira o número de eleitores: ");
eleitores = int.Parse(Console.ReadLine());
Console.Write("Insira o número de votos brancos: ");
votos_brancos = double.Parse(Console.ReadLine());
Console.Write("Insira o número de votos nulos: ");
votos_nulos = double.Parse(Console.ReadLine());
Console.Write("Insira o número de votos válidos: ");
votos_validos = double.Parse(Console.ReadLine());

votos_totais = votos_brancos + votos_nulos + votos_validos;

Console.WriteLine("\nPorcentual de votos brancos: " + (votos_brancos / votos_totais) * 100);
Console.WriteLine("Porcentual de votos nulos: " + (votos_nulos / votos_totais) * 100);
Console.WriteLine("Porcentual de votos válidos: " + (votos_validos / votos_totais) * 100);

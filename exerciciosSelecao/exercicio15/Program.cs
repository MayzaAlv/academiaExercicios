/* 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho 
 * em metros quadrados da área a ser pintada. Considere que a cobertura da tinta é 
 * de 1 litro para cada 3 metros quadrados e que a tinta é vendida em latas de 18 litros,
 * que custam R$ 80,00. Informe ao usuário a quantidades de latas de tinta a serem compradas
 * e o preço total. */

double metros, quantidade, preçoTotal;

Console.Write("Insira a quantidade da áre a ser pintada em metros quadrados: ");
metros = double.Parse(Console.ReadLine());

quantidade = (metros / 3) / 18;
preçoTotal = quantidade * 80;

Console.WriteLine($"Quantidade de latas: {Math.Round(quantidade)}" +
                  $"\nPreço total: {preçoTotal.ToString("F")}");

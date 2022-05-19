/* 13) Uma loja vende bicicletas com um acréscimo de 50% sobre o preço de custo. 
 * Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de 15% sobre o 
 * preço de custo de cada bicicleta vendida. Desenvolva um algoritmo que leia o valor 
 * do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas 
 * vendidas pelo vendedor, calcule e mostre: o salário do empregado */

Console.WriteLine("Exercício 13: Uma loja vende bicicletas com um acréscimo de 50% sobre o " +
    "preço de custo. Ela paga a cada vendedor 2 salários mínimos mensais, mais uma comissão de " +
    "15% sobre o preço de custo de cada bicicleta vendida.Desenvolva um algoritmo que leia o " +
    "valor do salário mínimo, o preço de custo de cada bicicleta e o número de bicicletas " +
    "vendidas pelo vendedor, calcule e mostre: o salário do empregado.\n");

double salario, preco_custo, salario_total;
int bicicleta_vendida;

Console.Write("Insira o salário mínimo: R$");
salario = double.Parse(Console.ReadLine());
Console.Write("Insira o preço de custo da bicicleta: R$");
preco_custo = double.Parse(Console.ReadLine());
Console.Write("Insira o número de bicicletas vendidas: ");
bicicleta_vendida = int.Parse(Console.ReadLine());

salario_total = (salario * 2) + ((preco_custo * 0.15) * bicicleta_vendida);

Console.WriteLine("Salário do vendedor: R$" + salario_total);

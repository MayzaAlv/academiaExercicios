/* 7) Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, 
 * o seu salário fixo, o total de vendas por ele efetuadas e o percentual que ganha 
 * sobre o total de vendas. Calcule o salário total do vendedor. Escreva o número do 
 * vendedor e o salário total do vendedor. */

Console.WriteLine("Exercício 7: Escreva um programa em C# e no Visual Studio que leia o " +
    "número de um vendedor, o seu salário fixo, o total de vendas por ele efetuadas e o " +
    "percentual que ganha sobre o total de vendas. Calcule o salário total do vendedor." +
    "Escreva o número do vendedor e o salário total do vendedor.\n");

int numero_vendedor;
float salario_fixo;
int vendas;
float percentual;
float salario_total;

Console.Write("Insira seu número: ");
numero_vendedor = int.Parse(Console.ReadLine());

Console.Write("Insira seu salário fixo: ");
salario_fixo = float.Parse(Console.ReadLine());

Console.Write("Insira seu número de vendas: ");
vendas = int.Parse(Console.ReadLine());

Console.Write("Insira o percentual que ganha do seu número de vendas: ");
percentual = float.Parse(Console.ReadLine());

salario_total = (vendas * (percentual / 100)) + salario_fixo;

Console.Write("\nNúmero: " + numero_vendedor + "\nSalário total: R$" + salario_total);


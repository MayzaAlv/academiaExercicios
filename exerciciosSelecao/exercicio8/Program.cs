/* 8 - Faça um programa no VS que receba o código, nome, salário base e o total de vendas 
 * de um funcionário.Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu 
 * salário final 5% do total de vendas.Caso o total de vendas seja mais que R$ 1000,00, 
 * adicionar ao seu salário final 7% do total de vendas.E por fim, se o total de vendas 
 * seja maior que R$ 5000,00, adicionar ao seu salário final 10% do total de vendas. *? */

double salario, totalVendas, salarioFinal;
int codigo;
string nome;

Console.Write("Insira seu código: ");
codigo = int.Parse(Console.ReadLine());

Console.Write("Insira seu nome: ");
nome = Console.ReadLine();

Console.Write("Insira seu salário: ");
salario = double.Parse(Console.ReadLine());

Console.Write("Insira seu total de vendas: ");
totalVendas = double.Parse(Console.ReadLine());

if (totalVendas > 500 && totalVendas <= 1000)
{
    salarioFinal = salario + (totalVendas * 0.05);
}
else if (totalVendas > 1000 && totalVendas <= 5000)
{
    salarioFinal = salario + (totalVendas * 0.07);
}
else if (totalVendas > 5000)
{
    salarioFinal = salario + (totalVendas * 0.1);
}
else {
    salarioFinal = salario;
}

Console.WriteLine($"Seu salário final é R${salarioFinal.ToString("F")} reais.");

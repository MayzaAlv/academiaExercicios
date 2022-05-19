/* 6) Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A
 * e para o parafuso B, isto é, o código, a quantidade de peças e o valor unitário de 
 * cada parafuso e a porcentagem de IPI (única) a ser acrescentada. */

Console.WriteLine("Exercício 6: Escreva um programa em C# e no Visual Studio que leia os dados" +
    " para o parafuso A e para o parafuso B, isto é, o código, a quantidade de peças e o valor " +
    "unitário de cada parafuso e a porcentagem de IPI(única) a ser acrescentada.\n");

int quantidade_A;
float valor_unitario_A;
float porcentagem_A;
float ipi_A;
float preco_A;

int quantidade_B;
float valor_unitario_B;
float porcentagem_B;
float ipi_B;
float preco_B;

Console.WriteLine("Dados do parafuso A:");

Console.Write("\nQuantidade de peças: ");
quantidade_A = int.Parse(Console.ReadLine());
Console.Write("Valor unitário: R$");
valor_unitario_A = float.Parse(Console.ReadLine());
Console.Write("Porcentagem de IPI: ");
porcentagem_A = float.Parse(Console.ReadLine());

ipi_A = (valor_unitario_A * (porcentagem_A / 100)) * quantidade_A;
preco_A = ipi_A + (valor_unitario_A * quantidade_A);

Console.WriteLine("\nDados do parafuso B:");

Console.Write("\nQuantidade de peças: ");
quantidade_B = int.Parse(Console.ReadLine());
Console.Write("Valor unitário: R$");
valor_unitario_B = float.Parse(Console.ReadLine());
Console.Write("Porcentagem de IPI: ");
porcentagem_B = float.Parse(Console.ReadLine());

ipi_B = (valor_unitario_B * (porcentagem_B / 100)) * quantidade_B;
preco_B = ipi_B + (valor_unitario_B * quantidade_B);

Console.WriteLine("\nPreço total do parafuso A: R$" + preco_A +
                  "\nPreço total do parafuso B: R$" + preco_B);

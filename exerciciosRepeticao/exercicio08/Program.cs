/* 8. Faça um programa em VS que solicite um numero inteiro. S
e o numero não for inteiro, solicite-o até que seja. após, informe se ele é par ou impar. 
Finalmente, pergunte ao usuário se ele quer repetir o programa em VS. */

int num;
string flag = "S";

do
{
    try
    {
        Console.Write("\nInsira um número inteiro: ");
        num = int.Parse(Console.ReadLine());
    }
    catch (FormatException) 
    {
        Console.WriteLine("Número invalido!");
        continue;
    }


    if (num % 2 == 0)
    {
        Console.WriteLine("É par!");
    }
    else
    {
        Console.WriteLine("É ímpar!");
    }

    Console.Write("\nDeseja repetir o programa (S ou N)? ");
    flag = Console.ReadLine().ToUpper();


} while (flag == "S");


/* 1. Faça um programa que leia um número inteiro n, inteiro e positivo e mostre a seguinte
soma: S = 1 + 1/2 + 1/3 + 1/4 + 1/5 .... 1/n */

int num, soma = 0;

do
{
    Console.Clear();

    Console.Write("Insira um número inteiro positivo: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("Insira um número válido!");
        Thread.Sleep(1000);
    }
    else
    {
        break;
    }

} while (true);


if (num > 0)
{
    Console.Write($"\nSoma: S = 1");
}


for (int i = 2; i <= num; i++) 
{
   
    if (i == num)
    {
        Console.Write($" + 1/{num}");
        break;
    }

    Console.Write($" + 1/{i}");
}

/* 6. Faça um programa que leia um número n e imprima se ele é primo ou não. 
(um número primo tem apenas 2 divisores: 1 e ele mesmo! O número 1 não é primo!!!) */

int num, count = 0;

do
{
    Console.Clear();

    try
    {
        Console.Write("Insira um número inteiro positivo para saber se ele é primo: ");
        num = int.Parse(Console.ReadLine());

        if (num < 0) 
        {
            Console.WriteLine("Número negativo é inválido! Insira um positivo!");
            Thread.Sleep(1000);
            continue;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Formato Inválido!");
        Thread.Sleep(1000);
        continue;
    }

    break;

} while (true);


for (int i = 1; i <= num; i++)
{
    if (num % i == 0)
    {
        count++;
    }
    if (count > 2) 
    {
        break;
    }
}

if (count == 2)
{
    Console.WriteLine($"O número {num} é primo.");
}
else
{
    Console.WriteLine($"O número {num} não é primo.");
}

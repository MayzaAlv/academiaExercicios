/* 3. Fazer um laço (repetição) que fique solicitando números ao usuário. 
Se o usuário digitar 0 o programa em VS deve parar. 
Caso contrário, o programa em VS deve informar se o 
número é par ou ímpar e se ele é um número primo. */

int num, count = 0;

do 
{
    Console.Write("\nInsira um número: ");
    num = int.Parse(Console.ReadLine());

    if (num == 0) 
    {
        break;
    }

    if (num % 2 == 0)
    {
        Console.WriteLine("É par!");
    }
    else {
        Console.WriteLine("É ímpar!");
    }

    for (int i = 1; i <= num; i++)
    {
        if (num % i == 0)
        {
            count++;
        }
    }

    if (count == 2)
    {
        Console.WriteLine("É um número primo.");
    }
    else
    {
        Console.WriteLine("Não é um número primo.");
    }

    count = 0;


} while (true);

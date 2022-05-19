/* 1. Faça um programa em VS que solicite um número inteiro positivo ao usuário, 
 * validando a entrada de dados (informando se ele estiver errado e repetindo a 
 * solicitação até que esteja correto). Após o programa em VS deve informar todos
 * os números pares existentes entre 1 e o número fornecido pelo usuário. */

int num;

do
{
    Console.Write("\nInsira um número inteiro válido: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("Número inválido! Digite novamente!");
    } else
    {
        Console.Write("\nNúmero pares entre 1 e " + num + ": ");

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0) {
                Console.Write(i + " ");
            }
        }
        break;
    }
} while (true);


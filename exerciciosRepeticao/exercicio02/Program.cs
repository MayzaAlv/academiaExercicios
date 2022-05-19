/* 2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja 
informar um outro número. Caso positivo, o programa em VS deve ser repetido. */

int num;
string flag;

do
{
    Console.Write("\nInsira um número inteiro válido: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0 || num % 1 != 0)
    {
        Console.WriteLine("Número inválido! Digite novamente!");
    }
    else
    {
        Console.Write("Número pares entre 1 e " + num + ": ");

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.Write("\nDeseja digitar outro número (S ou N)? ");
        flag = Console.ReadLine().ToUpper();

        if (flag == "N")
        {
            break;
        }
    }
} while (true);

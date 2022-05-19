/* 4 . Faça um algoritmo que leia uma lista de números inteiros positivos terminada 
 * pelo número 0 (zero). Ao final, o algoritmo deve mostrar a média aritmética de 
 * todos os números lidos (excluindo o zero). */

int num, soma = 0, count = 0;

do
{
    Console.Clear();

    Console.Write("Insira o número inteiro e positivo: ");
    num = int.Parse(Console.ReadLine());

    if (num < 0)
    {
        Console.WriteLine("Número Inválido!");
        Thread.Sleep(1000);

    } else if (num == 0)
    {
        Console.WriteLine("A média aritmética dos números lidos foi: " + soma / count);
        break;    
    }

    count++;
    soma += num;

} while (true);


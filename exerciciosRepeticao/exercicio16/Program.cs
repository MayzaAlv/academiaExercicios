/* 16. Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
(N*3; N*3*3; N*3*3*3; etc). */

int num;

do {
    Console.Write("Insira um valor menor ou igual a 50: ");
    num = int.Parse(Console.ReadLine());

    if (num <= 50)
    {
        break;
    }
    else
    {
        Console.WriteLine("Número inválido! Digite um valor entre 0 a 50!");
    }

} while(true);

do
{
    Console.WriteLine($"{num} * 3");
    num *= 3;

} while (num < 250);

Console.WriteLine("Resultando: " + num);


/* 7. Os dois primeiros números da sequência de Fibonacci são 0 e 1. Os próximos números dessa 
sequência podem ser calculados como sendo a soma dos dois números anteriores. Os primeiros
números de Fibonacci são: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, … Escreva um algoritmo 
que leia um número pelo teclado N, e então mostre os N primeiros números da sequência de Fibonacci. */

int num, valor = 0, anterior = 1;

do
{
    Console.Clear();

    try
    {
        Console.WriteLine("\tSequência de Fibonacci");

        Console.Write("\nInsira um número inteiro positivo: ");
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


for (int i = 0; i < num; i++)
{
    Console.Write(valor + " "); // mostra no console o valor da sequência

    valor += anterior; // soma com seu valor anterior
    anterior = valor - anterior; // pega o valor anterior do valor
}

/* 3 - Escrever um algoritmo para ler quatro valores inteiros,
 * calcular a sua média, e escrever na tela os que são superiores à média. */

int num1, num2, num3, num4;
double media;

Console.Write("Digite o número 1: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Digite o número 2: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Digite o número 3: ");
num3 = int.Parse(Console.ReadLine());

Console.Write("Digite o número 4: ");
num4 = int.Parse(Console.ReadLine());

media = (num1 + num2 + num3 + num4) / 4;

if (num1 > media) 
{
    Console.WriteLine($"O {num1} é superior a média que é {media}.");
}

if (num2 > media)
{
    Console.WriteLine($"O {num2} é superior a média que é {media}.");
}

if (num3 > media)
{
    Console.WriteLine($"O {num3} é superior a média que é {media}.");
}

if (num4 > media)
{
    Console.WriteLine($"O {num4} é superior a média que é {media}.");
}

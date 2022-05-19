/* 17 - Faça um algoritmo que leia o tamanho dos lados de um triangulo (lado a, b e c), 
 * e então diga se esses lados podem ou não formar um triangulo. Para que os lados formem
 * um triângulo, todos os lados devem ser menores ou iguais a soma dos outros dois lados. 
 * Caso os lados formem um triangulo, diga se o mesmo é equilátero (todos os lados iguais),
 * isoceles (somente 2 lados são iguais) ou escaleno (os 3 lados são diferentes). */

double ladoA, ladoB, ladoC, somaLados;

Console.Write("Insira o primeiro lado: ");
ladoA = int.Parse(Console.ReadLine());

Console.Write("Insira o segundo lado: ");
ladoB = int.Parse(Console.ReadLine());

Console.Write("Insira o terceiro lado: ");
ladoC = int.Parse(Console.ReadLine());

if (ladoA <= ladoB + ladoC && ladoB <= ladoA + ladoC && ladoC <= ladoA + ladoB)
{
    Console.WriteLine("\nPodem formar um triângulo.");
    if (ladoA == ladoB && ladoA == ladoC)
    {
        Console.WriteLine("É um triângulo equilátero.");
    }
    else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
    {
        Console.WriteLine("É um triângulo isosceles.");
    }
    else
    {
        Console.WriteLine("É um triângulo escaleno.");
    }
}
else {
    Console.WriteLine("\nNão podem formar um triângulo.");
}

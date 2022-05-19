/* 1) Escreva um programa em C# e no Visual Studio
 * para calcular a média aritmética entre dois
 * números quaisquer. */

Console.WriteLine("Escreva um programa em C# e no Visual Studio\n"
    + "para calcular a média aritmética entre dois números quaisquer.\n");

float numero1;
float numero2;

Console.Write("Escreva um número: ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Escreva um outro número: ");
numero2 = float.Parse(Console.ReadLine());

Console.WriteLine("A média aritmética entre os números é " + (numero1 + numero2) / 2);


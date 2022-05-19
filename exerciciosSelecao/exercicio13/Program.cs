/* 13 - Tendo como dado de entrada a altura (h) de uma pessoa, 
 * construa um programa no VS que calcule seu peso ideal, 
 * utilizando as seguintes fórmulas:
Para homens: (72.7 * h) - 58
Para mulheres: (62.1 * h) - 44.7 */

double altura, pesoIdeal;
string genero;

Console.Write("Insira sua altura: ");
altura = double.Parse(Console.ReadLine());

Console.Write("Insira seu gênero (H ou M): ");
genero = Console.ReadLine().ToUpper();

if (genero == "H")
{
    pesoIdeal = (72.7 * altura) - 58;
}
else {
    pesoIdeal = (62.1 * altura) - 44.7;
}

Console.WriteLine("Seu peso ideal é " + pesoIdeal.ToString("F"));


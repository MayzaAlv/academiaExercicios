/* 20 - Escreva um algoritmo para o jogo de adivinhação do número secreto.
 * O jogador tem 3 chances e recebe dicas do tipo “é maior” ou “é menor”. */

int valorJogador;
Random numeroAleatorio = new Random();
int valorInteiro = numeroAleatorio.Next(101);

for (int i = 1; i < 4; i++)
{
    Console.Write($"\nInsira o {i}o valor inteiro: ");
    valorJogador = int.Parse(Console.ReadLine());

    if (valorJogador > valorInteiro)
    {
        Console.WriteLine("É menor!");
    }
    else if (valorInteiro > valorJogador) 
    {
        Console.WriteLine("É maior!");
    }
    else
    {
        Console.WriteLine("Acertou!!!");
    }
}

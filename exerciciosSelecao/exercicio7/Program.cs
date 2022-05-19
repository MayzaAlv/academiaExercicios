/* 7 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem, como por 
exemplo, A palavra encontra-se na frase ou A palavra não se encontra na frase. */

string frase;

Console.Write("Digite uma frase: ");
frase = Console.ReadLine();

if (frase.Contains("comida"))
{
    Console.WriteLine($"A palavra 'comida' encontra-se na frase: '{frase}'");
}
else {
    Console.WriteLine($"A palavra 'comida' não encontra-se na frase: '{frase}'");
}

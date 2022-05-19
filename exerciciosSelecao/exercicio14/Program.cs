/* 14 - Faça um programa que peça o tamanho de um arquivo para download (em MB) e a 
 * velocidade de um link de Internet (em Mbps). Em seguida, calcule e informe o tempo
 * aproximado de download do arquivo usando este link (em minutos). */

double arqTamanho, velocidadeLink;

Console.Write("Insira o tamanho em MB: ");
arqTamanho = double.Parse(Console.ReadLine());

Console.Write("Insira a velocidade em Mbps: ");
velocidadeLink = double.Parse(Console.ReadLine());

Console.WriteLine("O tempo aproximado para completar o download é " + 
        ((arqTamanho / velocidadeLink) / 60).ToString("F") + " min");

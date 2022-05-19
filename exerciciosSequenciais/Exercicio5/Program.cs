/* 5) Escreva um programa em C# e no Visual Studio para calcular o 
 * consumo médio de um automóvel (medido em Km/l), sendo que são conhecidos
 * a distância total percorrida e o volume de combustível 
 * consumido para percorrê-la (medido em l). */

Console.WriteLine("Exercício 5: Escreva um programa em C# e no Visual Studio para calcular o " +
    "consumo médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância " +
    "total percorrida e o volume de combustível consumido para percorrê - la(medido em l).\n");

float distancia_percorrida;
float combustivel;
float consumo_medio;

Console.Write("Insira a distância percorrida (Km): ");
distancia_percorrida = float.Parse(Console.ReadLine());

Console.Write("Insira o volume de combustível consumido (L): ");
combustivel = float.Parse(Console.ReadLine());

consumo_medio = distancia_percorrida / combustivel;

Console.WriteLine("O consumo médio foi de " + consumo_medio);


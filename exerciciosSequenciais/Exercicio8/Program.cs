/* 8) Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
A fórmula da conversão é F=(9*C+160)/5. */

Console.WriteLine("Exercicio 8: Ler uma temperatura em graus Celsius e apresentá-la convertida" +
    " em graus Fahrenheit. A fórmula da conversão é F = (9 * C + 160) / 5.\n");

float temperatura_celsius;
float temperatura_Fahrenheit;

Console.Write("Insira a temperatura em Celsius: ");
temperatura_celsius = float.Parse(Console.ReadLine());

temperatura_Fahrenheit = (9 * temperatura_celsius + 160) / 5;
Console.Write("A temperatura em Fahrenheit é " + temperatura_Fahrenheit);


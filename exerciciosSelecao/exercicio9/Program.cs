/* 9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, 
 * representando a medição diária de um paciente diabético. Para cada valor recebido 
 * analisar e informar ao paciente o seguinte: Se o valor diário for menor que 65, 
 * avisá-lo que corre risco de hipoglicemia. Se o valor diário for maior que 250, 
 * avisá-lo que corre risco de hiperglicemia.

Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
150, avisá-lo que será necessário adicionar 2 unidades de insulina. */

double valor1, valor2, valor3, media;

Console.Write("Insira o valor 1o de glicemia: ");
valor1 = double.Parse(Console.ReadLine());

if (valor1 < 65) {
    Console.WriteLine("Risco de hipoglicemia!");
} else if (valor1 > 250) {
    Console.WriteLine("Risco de hiperglicemia!");
}

Console.Write("\nInsira o valor 2o de glicemia: ");
valor2 = double.Parse(Console.ReadLine());

if (valor2 < 65)
{
    Console.WriteLine("Risco de hipoglicemia!");
}
else if (valor2 > 250)
{
    Console.WriteLine("Risco de hiperglicemia!");
}

Console.Write("\nInsira o valor 3o de glicemia: ");
valor3 = double.Parse(Console.ReadLine());

if (valor3 < 65)
{
    Console.WriteLine("Risco de hipoglicemia!");
}
else if (valor3 > 250)
{
    Console.WriteLine("Risco de hiperglicemia!");
}

media = (valor1 + valor2 + valor3) / 3;

if (media < 80)
{
    Console.WriteLine("\nÉ preciso diminuir 2 unidades de insulina");
}
else if (media > 150)
{
    Console.WriteLine("\nÉ necessário adicionar 2 unidades de insulina.");
}

/* 6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), 
 * a altura (metros) e o peso (kg) de uma pessoa. O programa deve calcular o Indice de Massa 
 * Corpórea (IMC), exibi-lo ao usuário e informar sua situação conforme a tabela.
 * O cálculo do imc = peso / (altura * altura)

IMC 
menor que 18                -> baixo peso
maior que 18 e menor que 25 -> peso normal
maior que 25 e menor que 30 -> sobrepeso
maior que 30 e menor que 35 -> obesidade
maior que 35                -> obesidade grau sério */

string nome;
double peso, altura, imc;

Console.Write("Digite o nome: ");
nome = Console.ReadLine().ToUpper();

Console.Write("Digite o peso: ");
peso = double.Parse(Console.ReadLine());

Console.Write("Digite a altura: ");
altura = double.Parse(Console.ReadLine());

imc = peso / (altura * altura);

if (imc < 18)
{
    Console.WriteLine($"Seu imc é {imc.ToString("F")}. Está em baixo peso.");
}
else if (imc > 18 && imc < 25) {
    Console.WriteLine($"Seu imc é {imc.ToString("F")}. Está em peso normal.");
}
else if (imc > 25 && imc < 30)
{
    Console.WriteLine($"Seu imc é {imc.ToString("F")}. Está em sobrepeso.");
}
else if (imc > 30 && imc < 35)
{
    Console.WriteLine($"Seu imc é {imc.ToString("F")}. Está em obesidade.");
}
else
{
    Console.WriteLine($"Seu imc é {imc.ToString("F")}. Está em obesidade grau sério.");
}

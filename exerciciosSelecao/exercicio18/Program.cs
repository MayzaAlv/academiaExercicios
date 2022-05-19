/* 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles. */

double valor1, valor2, valor3;

Console.Write("Insira o primeiro valor: ");
valor1 = double.Parse(Console.ReadLine());

Console.Write("Insira o segundo valor: ");
valor2 = double.Parse(Console.ReadLine());

Console.Write("Insira o terceiro valor: ");
valor3 = double.Parse(Console.ReadLine());

List<double> lista = new List<double> {valor1, valor2, valor3};
double maiorValor = lista.Max();

Console.WriteLine("\nO maior valor é " + maiorValor);

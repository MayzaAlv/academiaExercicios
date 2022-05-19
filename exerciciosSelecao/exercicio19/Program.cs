/* 19 - Ajuste o exercício 3 de maneira que mostre os valores informados em ordem crescente.*/

double valor1, valor2, valor3;

Console.Write("Insira o primeiro valor: ");
valor1 = int.Parse(Console.ReadLine());

Console.Write("Insira o segundo valor: ");
valor2 = int.Parse(Console.ReadLine());

Console.Write("Insira o terceiro valor: ");
valor3 = int.Parse(Console.ReadLine());

List<double> lista = new List<double> { valor1, valor2, valor3 };
lista.Sort();

Console.Write("\nOrdem crescente: ");
foreach (double v in lista) {
    Console.Write(v + " ");
}

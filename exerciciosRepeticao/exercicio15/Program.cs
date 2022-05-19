/* 15. Ler 4 valores referentes a notas escolares de um aluno e imprimir uma mensagem 
 * dizendo se ele está aprovado ou reprovado, após ter calculado sua média ponderando, 
 * considerando pesos 2, 1, 2, e 4, respectivamente. Considerar nota 7,0 como mínima para aprovação. */

double[] pesos = new double[] { 2, 1, 2, 4};
double media = 0, nota;

for (int i = 0; i < 4; i++)
{
    Console.Write("Insira a nota: ");
    nota = double.Parse(Console.ReadLine());

    media += nota * (pesos[i] / 10);
}

Console.WriteLine("\nMédia de " + media + "!");

if (media < 7)
{
    Console.WriteLine("Reprovado!");
}
else
{
    Console.WriteLine("Aprovado!");
}

/* 5 - Escrever um algoritmo para ler duas notas de um aluno e 
 * escrever na tela a palavra “Aprovado” se a média das duas notas 
 * for maior ou igual a 7,0. Caso a média seja inferior a 7,0, o 
 * programa deve ler a nota do exame e calcular a média final. 
 * Se esta média for maior ou igual a 5,0, o programa deve escrever 
 * “Aprovado”, caso contrário deve escrever “Reprovado”. */

double nota1, nota2, notaExame, media, mediaFinal;

Console.Write("Insira a primeira nota: ");
nota1 = double.Parse(Console.ReadLine());

Console.Write("Insira a segunda nota: ");
nota2 = double.Parse(Console.ReadLine());

media = (nota1 + nota2) / 2;

if (media > 7.0)
{
    Console.WriteLine($"Nota final {media}. Aprovado!");

}
else {
    Console.WriteLine($"Nota final {media}. Reprovado!");

    Console.Write("\nInsira a nota do exame: ");
    notaExame = double.Parse(Console.ReadLine());

    mediaFinal = (media + notaExame) / 2;

    if (mediaFinal >= 5.0) {
        Console.WriteLine($"Média final de {mediaFinal}. Aprovado!");
    } else {
        Console.WriteLine($"Média final de {mediaFinal}. Reprovado!");
    }
}

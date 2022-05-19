/* 11. Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa, 
a média aritmética da turma e a quantidade de alunos da turma. Usar como flag a nota 12. */


List<double> notas = new List<double> ();

do {
    Console.Clear();

    Console.Write("Insira a nota do aluno (12 para sair): ");
    notas.Add(double.Parse(Console.ReadLine()));

    if (notas.Contains(12))
    {
        notas.Remove(12);
        break;
    }
    
} while (true);

double media = notas.Sum() / notas.Count();

Console.WriteLine($"\nNota mais alta: {notas.Max()} \nNota mais baixa:{notas.Min()}");
Console.WriteLine($"Média Aritmética: {media.ToString("F")} \nQuantidade de alunos:{notas.Count()}");

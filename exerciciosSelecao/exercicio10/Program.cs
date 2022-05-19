/* 10 - Faça um programa no VS que receba dados de dois atletas (nome, idade e altura).
O programa deve mostrar os dados do atleta mais novo e mais alto. */

string nome1, nome2;
int idade1, idade2;
double altura1, altura2;

Console.Write("Insira o nome do primeiro atleta: ");
nome1 = Console.ReadLine();

Console.Write("Insira a idade do primeiro atleta: ");
idade1 = int.Parse(Console.ReadLine());

Console.Write("Insira a altura do primeiro atleta: ");
altura1 = double.Parse(Console.ReadLine());

Console.Write("\nInsira o nome do segundo atleta: ");
nome2 = Console.ReadLine();

Console.Write("Insira a idade do segundo atleta: ");
idade2 = int.Parse(Console.ReadLine());

Console.Write("Insira a altura do segundo atleta: ");
altura2 = double.Parse(Console.ReadLine());

if (idade1 < idade2 && altura1 > altura2)
{
    Console.WriteLine($"\nNome: {nome1}\nIdade: {idade1}\nAltura:{altura1}");

}
else if (idade1 > idade2 && altura1 < altura2)
{
    Console.WriteLine($"\nNome: {nome2}\nIdade: {idade2}\nAltura:{altura2}");
}

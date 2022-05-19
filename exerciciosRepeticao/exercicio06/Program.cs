/* 6. Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados, 
ou seja, repita a leitura até que ela esteja correta (maior do que zero). 
Ao final, mostre a idade digitada. */

int idade;

do 
{
    Console.Clear();

    Console.Write("Insira sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (idade > 0)
    {
        Console.WriteLine("\nSua idade é de " + idade + " anos.");
        break;
    }
    else 
    {
        Console.WriteLine("Digite uma idade válida!");
        Thread.Sleep(1000);
    }

} while (true);

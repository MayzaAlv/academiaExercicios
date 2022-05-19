/* 19. A prefeitura de uma cidade fez uma pesquisa entre seus habitantes, 
coletando dados sobre o salário e número de filhos. A prefeitura deseja saber: 
 
a) média do salário da população;
b) média do número de filhos;
c) maior salário;
d) percentual de pessoas com salário até R$ 100,00.
O final da leitura de dados se dará com a entrada de um salário negativo. */


List<double> salario = new List<double> ();
List<int> filhos = new List<int> ();
double tmp, pessoas = 0;

do
{
    Console.Clear();

    Console.Write("Insira seu salário: ");
    tmp = double.Parse(Console.ReadLine());

    if (tmp < 0)
    {
        break;
    }
    else
    {
        if (tmp <= 100) 
        {
            pessoas++;
        }

        salario.Add(tmp);

        Console.Write("Insira a quantidade de filhos: ");
        filhos.Add(int.Parse(Console.ReadLine()));
    }

} while (true);

double media = salario.Sum() / salario.Count();

Console.WriteLine($"\nMédia do salário da população: " + media.ToString("F"));
Console.WriteLine($"Média do número de filhos da população: " + filhos.Sum() / filhos.Count());
Console.WriteLine($"Maior salário: " + salario.Max());
Console.WriteLine("Percentual de pessoas com salário até R$ 100,00: " +
                    (pessoas / salario.Count()) * 100);

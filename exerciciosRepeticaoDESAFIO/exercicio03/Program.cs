/* 3.Dado um limite inferior e superior, calcule a soma de todos os números pares contidos
nesse intervalo. */

int inferior, superior, somaPares = 0;

Console.Write("Insira o número inferior: ");
inferior = int.Parse(Console.ReadLine());

Console.Write("Insira o número superior: ");
superior = int.Parse(Console.ReadLine());

for (int i = inferior; i <= superior; i++)
{
    if (i % 2 == 0)
    {
        somaPares += i;
    }
}

Console.WriteLine("\nSoma dos números pares: " + somaPares);

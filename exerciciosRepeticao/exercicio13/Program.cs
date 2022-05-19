/* 13. Elaborar um programa que apresente o somatório dos valores pares existentes 
entre 1 e 500. */

int somaPares = 0;

for (int i = 0; i < 501; i++)
{
    if (i % 2 == 0) 
    {
        somaPares += i;
    }
}

Console.WriteLine("Soma dos valores pares entre 1 e 500: " + somaPares);

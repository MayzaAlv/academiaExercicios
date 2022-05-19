/* 9. Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram 
o zoológico num determinado dia, imprimindo: */

int filhos, count0 = 0, count1e3 = 0, count4e7 = 0, count8 = 0;


for (int i = 0; i < 30; i++) 
{
    Console.Clear();

    Console.Write($"\nInsira a quantidade de filhos da pessoa: ");
    filhos = int.Parse(Console.ReadLine());


    if (filhos == 0)
    {
        count0++;
    }
    else if (filhos < 4)
    {
        count1e3++;
    }
    else if (filhos < 8)
    {
        count4e7++;
    }
    else
    {
        count8++;
    }

}

Console.WriteLine($"\nTem {count1e3} pessoas entre 1 e 3 filhos.");
Console.WriteLine($"\nTem {count4e7} pessoas entre 4 e 7 filhos.");
Console.WriteLine($"\nTem {count8} pessoas tem mais de 8 filhos.");
Console.WriteLine($"\nTem {count0} pessoas com nenhum filho.");


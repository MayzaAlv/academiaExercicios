/* 5. Modifique o programa em VS anterior para aceitar votos nulos 
(qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
Ao final, informe o nome do candidato vencedor, o número de votos nulos 
e o número de pessoas que votaram. */

int joao = 0, zeca = 0, branco = 0, nulos = 0;
string voto;

do
{
    Console.Clear();
    Console.Write("\nInsira em quem deseja votar ou branco (Fim para encerrar): ");
    voto = Console.ReadLine().ToUpper();

    switch (voto)
    {
        case "JOAO":
            joao++;
            break;

        case "ZECA":
            zeca++;
            break;

        case "BRANCO":
            branco++;
            break;

        case "FIM":
            Console.WriteLine("Programa Encerrado!");
            break;

        default:
            nulos++;
            break;
    }
}
while (voto != "FIM");

Console.WriteLine($"\nTotal de votos:\nJoão: {joao} "+
                $"\nZeca: {zeca} \nEm branco: {branco}"
                +$"\nVoto nulos: {nulos}");

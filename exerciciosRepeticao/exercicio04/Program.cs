/* 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. 
O mesmo para ZECA. Você também pode aceitar votos em branco (palavra BRANCO). 
O programa em VS termina quando o usuário escrever FIM. Ao final devem ser mostradas
as quantidades de votos para cada um dos candidatos e o número de votos em branco.  */

int joao = 0, zeca = 0, branco = 0;
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
            Console.WriteLine("Candidato inexistente.");

            Thread.Sleep(1000);
            break;
    }
}
while (voto != "FIM");

Console.WriteLine($"\nTotal de votos:\nJoão: {joao} \nZeca: {zeca} \nEm branco: {branco}");

/* 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
certa região, a qual coletou os seguintes dados referentes a cada habitante para 
serem analisados:
- sexo (masculino e feminino)
- cor dos olhos (azuis, verdes ou castanhos)
- cor dos cabelos ( louros, castanhos, pretos)
- idade 
 
Faça um algoritmo que determine e escreva: 
 
- a maior idade dos habitantes
- a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
e que tenham olhos verdes e cabelos louros.
O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade. */


List<Pessoa> pessoas = new List<Pessoa> ();

do
{
    Console.Clear();

    Pessoa pessoa = new Pessoa ();

    Console.Write("Digite sua idade: ");
    pessoa.idade = int.Parse(Console.ReadLine());

    if (pessoa.idade == -1)
    {
        break;
    }

    Console.Write("Digite seu gênero (F ou M): ");
    pessoa.sexo = Console.ReadLine().ToUpper();

    Console.Write("Digite a cor dos olhos (azul, verde ou castanho): ");
    pessoa.corOlhos = Console.ReadLine().ToUpper();

    Console.Write("Digite a cor dos cabelos (louro, castanho ou preto): ");
    pessoa.corCabelos = Console.ReadLine().ToUpper();

    pessoas.Add(pessoa);
}
while (true);


if (pessoas.Count() > 0)
{
    int quant = 0;
    int idadeMax = pessoas[0].idade;

    for (int i = 1; i < pessoas.Count(); i++)
    {
        if (idadeMax < pessoas[i].idade)
        {
            idadeMax = pessoas[i].idade;
        }
    }

    for (int i = 0; i < pessoas.Count(); i++)
    {
        if ((pessoas[i].sexo == "F" || pessoas[i].sexo == "FEMININO")
            && pessoas[i].idade >= 18 && pessoas[i].idade <= 35
            && pessoas[i].corOlhos == "VERDE" &&
            pessoas[i].corCabelos == "LOURO")
        {
            quant++;
        }
    }

    Console.WriteLine("\nMaior idade dos habitantes: " + idadeMax +
                      "\nQuantidade de indivíduos do sexo feminino cuja idade" +
                      " está entre 18 e 35 anos\ninclusive e que tenham olhos verdes" +
                      " e cabelos louros: " + quant);
}


public class Pessoa {

    public string sexo;
    public string corOlhos;
    public string corCabelos;
    public int idade;

    public Pessoa() {}
}

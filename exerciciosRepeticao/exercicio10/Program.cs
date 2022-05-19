/* 10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
Número de pessoas do sexo masculino.
Número de pessoas do sexo feminino.
Número de pessoas com idade inferior a 30 anos.
Número de pessoas com idade superior a 60 anos.
Média de idade das mulheres. */

List<Pessoa> pessoas = new List<Pessoa>();
int countF = 0, countM = 0, countInferior = 0, countSuperior = 0, idadeF = 0;

for (int i = 0; i < 50; i++) 
{
    string nome, sexo;
    int idade;

    Console.Write("Insira seu nome: ");
    nome = Console.ReadLine();

    Console.Write("Insira seu sexo: ");
    sexo = Console.ReadLine().ToUpper();

    Console.Write("Insira sua idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Clear();

    pessoas.Add(new Pessoa(nome, sexo, idade));
}


for (int i = 0; i < pessoas.Count(); i++) 
{
    if (pessoas[i].sexo == "F" || pessoas[i].sexo == "FEMININO") 
    {
        countF++;
        idadeF += pessoas[i].idade;
    }
    else if (pessoas[i].sexo == "M" || pessoas[i].sexo == "MASCULINO")
    {
        countM++;
    }

    if (pessoas[i].idade < 30) 
    {
        countInferior++;    
    }
    else if (pessoas[i].idade > 60)
    {
        countSuperior++;
    }
}

Console.WriteLine("Número de pessoas do sexo Feminino: " + countF);
Console.WriteLine("Número de pessoas do sexo Masculino: " + countM);
Console.WriteLine("Número de pessoas com idade inferior a 30 anos: " + countInferior);
Console.WriteLine("Número de pessoas com idade superior a 60 anos. " + countSuperior);
Console.WriteLine("Média de idade das mulheres: " + idadeF / countF);


public class Pessoa
{
    private string nome { get; set; }
    public string sexo { get; set; }
    public int idade { get; set; }

    public Pessoa (string nome, string sexo, int idade)
    {
        this.nome = nome;
        this.sexo = sexo;
        this.idade = idade;
    }
}


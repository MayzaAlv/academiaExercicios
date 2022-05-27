/* #5
Crie uma classe para representar um item de cenário, com os atributos privados de:
    * descrição (string), 
    * data de criação (date - https://docs.microsoft.com/en-us/dotnet/api/system.datetime.date?view=net-6.0) e
    * altura (float). 

Crie os métodos públicos necessários para sets e gets, o construtor básico e também um método para imprimir 
todos dados de um item de cenário. 
Por fim, crie um método para calcular a quanto tempo o item foi criado, além de um programa em C# para testar
a classe criada. */

using exercicio05;

List<Item> itens = new List<Item>();
string opcao, nome, descricao;
double altura;

do
{
    Console.WriteLine("\n1 - Criar um item");
    Console.WriteLine("2 - Exibir lista de itens");
    Console.WriteLine("3 - Exibir um item");
    Console.WriteLine("4 - Data de criação");
    Console.WriteLine("5 - Sair");

    Console.Write("\nInsira a opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();

            Console.Write("Insira o nome: ");
            nome = Console.ReadLine();

            Console.Write("Insira a descrição: ");
            descricao = Console.ReadLine();

            Console.Write("Insira a altura: ");
            altura = double.Parse(Console.ReadLine());

            itens.Add(new Item(nome, descricao, altura));
            break;

        case "2":
            Item.ExibirDados(itens);
            break;

        case "3":
            Item.ExibirDadosItem(itens);
            break;

        case "4":
            Item.ExibirData(itens);
            break;

        case "5":
            Console.WriteLine("Obrigado por usar o programa!");
            break;

        default:
            Console.WriteLine("Insira uma posição válida!");
            break;
    }
}
while (opcao != "5");

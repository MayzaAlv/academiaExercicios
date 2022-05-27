/* #6
Crie uma classe para representar um objeto em um Plano Cartesiano. Todo objeto no plano cartesiano
tem como atributos 'x' e 'y'. Dessa forma, crie os getters e setter de 'x' e 'y', o construtor básico e
um método para exibir um objeto (x,y).
Por fim, crie um programa em C# que cadastre 'n' objetos em uma lista (List), um método de que exiba
os objetos da lista. */

using exercicio06;

List<Objeto> objetos = new List<Objeto>();  
int posicaoX, posicaoY;
string opcao;

do
{
    Console.WriteLine("\n1 - Cadastrar um objeto");
    Console.WriteLine("2 - Exibir lista de objetos");
    Console.WriteLine("3 - Sair");

    Console.Write("\nInsira a opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Write("\nInsira a posição x: ");
            posicaoX = int.Parse(Console.ReadLine());

            Console.Write("Insira a posição y: ");
            posicaoY = int.Parse(Console.ReadLine());

            objetos.Add(new Objeto(posicaoX, posicaoY));
            break;

        case "2":
            Objeto.ExibirDados(objetos);
            break;

        case "3":
            Console.WriteLine("Obrigado por usar o programa!");
            break;

        default:
            Console.WriteLine("Insira uma posição válida!");
            break;
    }
}
while (opcao != "3");

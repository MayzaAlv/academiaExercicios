using main;

List<Pessoa> pessoas = new List<Pessoa>();

string opcao, nomeArquivo = "pessoas.dat";

try
{
    StreamReader leitor = new StreamReader(nomeArquivo);
    string[] dados;

    do
    {
        dados = leitor.ReadLine().Split(";");
        Pessoa p = new Pessoa(dados[0], dados[1]);

        pessoas.Add(p);
    } while (!leitor.EndOfStream);

    leitor.Close();
}
catch (IOException) {}

StreamWriter escritor = new StreamWriter(nomeArquivo, true);

do
{
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar uma pessoa");
    Console.WriteLine("2 - Exibir email das pessoas");
    Console.WriteLine("3 - Exibir pessoas");
    Console.WriteLine("4 - Sair");

    Console.Write("Opção: ");
    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            cadastrarPessoa();
            break;

        case "2":
            Console.WriteLine("\nExibindo o email de pessoas:");

            foreach (Pessoa i in pessoas) 
            {
                Console.WriteLine(i.Email);
            }

            break;

        case "3":
            Console.WriteLine("\nExibindo a lista de pessoas:");

            foreach (Pessoa i in pessoas)
            {
                Console.WriteLine(i.Nome + " - " + i.Email);
            }
                
            break;

        case "4":
            Console.WriteLine("\nObrigado por usar o sistema!");
            break;

        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }

    Console.Write("\nPressione algo para continuar!");
    Console.ReadKey();

} while (opcao != "4");


void cadastrarPessoa() {
    //receber um email e gravar no arquivo
    try
    {
        string nome, email;

        Console.Write("\nDigite nome: ");
        nome = Console.ReadLine().ToUpper();

        Console.Write("Digite email: ");
        email = Console.ReadLine().ToLower();

        //criar um objeto Pessoa com os valores nome e email
        Pessoa p = new Pessoa(nome, email);

        //verificar se essa dupla já está na lista, logo no arquivo
        bool jaCadastrado = false;

        foreach (Pessoa i in pessoas)
        {
            if (i.Email.Equals(email))
            {
                Console.WriteLine("\nEsse email já está no sistema!\n");
                jaCadastrado = true;
                break;
            }
        }

        if (!jaCadastrado)
        {
            //adicionar o objeto na lista
            pessoas.Add(p);
            //adicionar o objeto no arquivo
            escritor.WriteLine(p.Nome + ";" + p.Email); //literalmente escreve no procurador e em memória
            escritor.Flush(); //garante depois de cada frase digitada que vá para o arquivo                
        }
    }

    catch (IOException e)
    {
        Console.WriteLine("\nErro ao gravar o arquivo: " + e.Message);
    }
}


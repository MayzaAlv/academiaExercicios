using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Trabalho para entender e aplicar a teoria de Orientação a Objetos (terceirização), uso adequado de 
 * Listas e Arquivos.
 * Além disso, aplicar a ideia de menu de opções.
 
Construir um programa em VS que gerencie veículos em garagem. O programa deve ter um menu de operação. 
Os dados dos veículos devem ser persistidos em arquivo e manipulados em uma lista dinâmica em memória.
Os dados dos veículos são : string placa; DateTime dataHoraEntrada.

MENU
1 - Cadastrar veículo entrando na garagem
2 - Exibir veículos cadastrados
3 - Sair
Opção: 

Observações: Criar a classe Veiculo (placa, dataHoraEntrada); usar as classes List, 
StreamReader, StreamWriter, DateTime. Use como base de dados o arquivo 'garagem.dat'. */


namespace gerenciamentoGaragem
{
    internal class App
    {
        private static List<Veiculo> veiculos = new List<Veiculo>();

        public static void Main()
        {
            carregarListas();
            string opcao;

            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Cadastrar veículo entrando na garagem");
                Console.WriteLine("2 - Exibir veículos cadastrados");
                Console.WriteLine("3 - Sair");

                Console.Write("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        //cadastrar um veículo;
                        cadastrarVeiculo("Cadastrando veículo");
                        break;
                    case "2":
                        //listar veículos;
                        exibirLista("Exibindo a lista de veículos");
                        break;
                    case "3":
                        Console.WriteLine("Obrigado por usar o sistema");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.Write("Pressione algo para continuar!");
                Console.ReadKey();
            } while (opcao != "3");

        }


        private static void carregarListas()
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;

            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //placa;data e hora de entrada
                    veiculos.Add(new Veiculo(vetorDados[0], vetorDados[1]));

                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo

                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Arquivo de usuários com problemas ou inexistente");
            }
        }


        private static void cadastrarVeiculo(string frase)
        {
            Console.WriteLine(frase);

            string placa;

            Console.Write("Digite a placa: ");
            placa = Console.ReadLine();

            Veiculo objeto = new Veiculo(placa);

            if (!jaCadastrado(objeto))
            {
                veiculos.Add(objeto);
                //gravar no arquivo
                gravarArquivo(objeto);
            }
            else
            {
                Console.WriteLine("Carro com essa placa já está na base de dados!");

            }
        }

        private static bool jaCadastrado(Veiculo objeto)
        {
            foreach (Veiculo i in veiculos)
            {
                if (objeto.Placa.Equals(i.Placa))
                {
                    return true;
                }
            }
            return false;
        }

        private static void gravarArquivo(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(objeto.Placa + ";" + objeto.DataHoraEntrada);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Arquivo de usuários com problemas");
            }
        }

        public static void exibirLista(string frase)
        {
            Console.WriteLine(frase);
            foreach (Veiculo i in veiculos)
            {
                Console.WriteLine(i.Placa + " - " + i.DataHoraEntrada);
            }
        }
    }
}
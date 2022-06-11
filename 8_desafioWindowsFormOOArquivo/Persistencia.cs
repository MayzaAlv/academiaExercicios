using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_desafioWindowsFormOOArquivo
{
    internal class Persistencia
    {
        /// <summary>
        /// Método para ler o arquivo de veiculo das entradas
        /// </summary>
        /// <returns>Retorna a lista depois de populada com os veículos do arquivo</returns>
        public static List<Veiculo> LerArquivoVeiculosEntrada()
        {
            List<Veiculo> veiculosEntrada = new List<Veiculo>();
            StreamReader leitor;
            string nomeArquivo = "veiculosEntrada.dat", dados;
            string[] vetorDados;

            try
            {
                leitor = new StreamReader(nomeArquivo);

                do
                {
                    dados = leitor.ReadLine();

                    if (!String.IsNullOrEmpty(dados))
                    {
                        vetorDados = dados.Split(';');
                        veiculosEntrada.Add(new Veiculo(vetorDados[1],
                                        DateTime.Parse(vetorDados[2]), vetorDados[0]));
                    }
                } while (!leitor.EndOfStream);
                leitor.Close();     
            }
            catch (Exception) { }
            return veiculosEntrada;
        }

        /// <summary>
        /// Método para gravar os veículos de entrada no arquivo
        /// </summary>
        /// <param name="objeto">Objeto veículo para colocar no arquivo</param>
        public static void GravarArquivoVeiculosEntrada(Veiculo objeto)
        {
            try
            {
                List<Veiculo> veiculosEntrada = LerArquivoVeiculosEntrada();
                StreamWriter escritor = new StreamWriter("veiculosEntrada.dat", true);

                escritor.WriteLine(objeto.PlacaVeiculo.ToUpper() + ";" + objeto.DataEntrada
                                  + ";" + objeto.HoraEntrada.ToString("HH:mm"));
 
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Método para ler o arquivo de veiculo das saídas
        /// </summary>
        /// <returns>Retorna a lista depois de populada com os veículos do arquivo</returns>
        public static List<Veiculo> LerArquivoVeiculosSaida()
        {
            List<Veiculo> veiculosSaida = new List<Veiculo>();
            StreamReader leitor;
            string nomeArquivo = "veiculosSaida.dat";
            string[] vetorDados;

            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(';');

                    veiculosSaida.Add(new Veiculo(vetorDados[0], double.Parse(vetorDados[1]),
                                                    double.Parse(vetorDados[2])));
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception) { }
            return veiculosSaida;
        }

        /// <summary>
        /// Método para gravar os veículos de saída no arquivo
        /// </summary>
        /// <param name="objeto">Objeto veículo para colocar no arquivo</param>
        public static void GravarArquivoVeiculosSaida(Veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("veiculosSaida.dat", true);

                escritor.WriteLine(objeto.PlacaVeiculo.ToUpper() + ";" + objeto.TempoPermanencia 
                                    + ";" + objeto.ValorCobrado);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception) { }    
        }

        /// <summary>
        /// Método para atualizar o arquivo quando for removido algum veículo 
        /// e refazer o arquivo com os dados corretos
        /// </summary>
        /// <param name="veiculosEntrada">Lista com os veículos</param>
        /// <param name="nomeArquivo">Nome do arquivo que deseja modificar</param>
        public static void AtualizarArquivo(List<Veiculo> veiculosEntrada, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo);

            foreach (Veiculo item in veiculosEntrada)
            {
                if(nomeArquivo == "veiculosEntrada.dat")
                {
                    escritor.WriteLine(item.PlacaVeiculo.ToUpper() + ";" + item.DataEntrada
                                      + ";" + item.HoraEntrada.ToString("HH:mm"));
                }
                else
                {
                    escritor.WriteLine(item.PlacaVeiculo.ToUpper() + ";" + item.TempoPermanencia
                                      + ";" + item.ValorCobrado);
                }
                escritor.Flush();
            }
            escritor.Close();
        }
    }
}
   

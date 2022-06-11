using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_desafioWindowsFormOOArquivo
{
    public class Veiculo
    {
        private double valorCobrado, tempoPermanencia;
        private string placaVeiculo, dataEntrada;
        private DateTime horaEntrada;

        /// <summary>
        /// Construtor usado para popular o arquivo de entrada
        /// </summary>
        /// <param name="dataEntrada"></param>
        /// <param name="horaEntrada"></param>
        /// <param name="placaVeiculo"></param>
        public Veiculo(string dataEntrada, DateTime horaEntrada, string placaVeiculo)
        {
            this.dataEntrada = dataEntrada;
            this.horaEntrada = horaEntrada;
            this.placaVeiculo = placaVeiculo;
        }

        /// <summary>
        /// Construtor usado para popular o arquivo de saída
        /// </summary>
        /// <param name="placaVeiculo"></param>
        /// <param name="tempoPermanencia"></param>
        /// <param name="valorCobrado"></param>
        public Veiculo(string placaVeiculo, double tempoPermanencia, double valorCobrado)
        {
            this.placaVeiculo = placaVeiculo;
            this.tempoPermanencia = tempoPermanencia;
            this.valorCobrado = valorCobrado;
        }

        /// <summary>
        /// Construtor usado para criar um novo veiculo
        /// </summary>
        public Veiculo() { }

        public double ValorCobrado { get => valorCobrado; set => valorCobrado = value; }
        public double TempoPermanencia { get => tempoPermanencia; set => tempoPermanencia = value; }
        public string DataEntrada { get => dataEntrada; set => dataEntrada = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public string PlacaVeiculo { get => placaVeiculo; set => placaVeiculo = value; }

        /// <summary>
        /// Método que verifica se um veículo já foi cadastrado na lista de 
        /// </summary>
        /// <param name="objeto">O Veículo que deseja saber se foi cadastrado</param>
        /// <param name="veiculos">Lista de todos veículos</param>
        /// <returns>Verdadeiro se foi cadastrado, se não, retorna falso</returns>
        public static bool VerificarCadastro(Veiculo objeto, List<Veiculo> veiculos)
        {
            foreach (Veiculo item in veiculos)
            {
                if (objeto.PlacaVeiculo.Equals(item.PlacaVeiculo))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método que verifica se tem lugar disponível na garagem
        /// </summary>
        /// <param name="veiculos">Lista com o total de veículo</param>
        /// <param name="quantidadeDeLugar">Quantidade de lugar disponível na garagem</param>
        /// <returns>Verdadeiro se tem ludar disponível, se não, retorna falso</returns>
        public static bool LugarDisponiveis(List<Veiculo> veiculos, int quantidadeDeLugar)
        {
            return veiculos.Count() <= quantidadeDeLugar;
        }
    }
}

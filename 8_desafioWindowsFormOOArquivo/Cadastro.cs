using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_desafioWindowsFormOOArquivo
{
    public partial class Cadastro : Form
    {
        /// <summary>
        /// Listas dos veículos de entrada e saída
        /// </summary>
        public static List<Veiculo> veiculosEntrada = new List<Veiculo>();
        public static List<Veiculo> veiculosSaida = new List<Veiculo>();

        /// <summary>
        /// Construtor com as configurações do programa e iniciando as listas com 
        /// dados do arquivo, ademais, exibindo a data do momento
        /// </summary>
        public Cadastro()
        {
            InitializeComponent();
            veiculosEntrada = Persistencia.LerArquivoVeiculosEntrada();
            veiculosSaida = Persistencia.LerArquivoVeiculosSaida();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Evento de click do botão de entrada, faz toda a verificação, 
        /// grava no arquivo e atualiza a lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                Veiculo veiculo = new Veiculo(txtData.Text, DateTime.Parse(mtbHora.Text), txtPlaca.Text);

                if (!Veiculo.VerificarCadastro(veiculo, veiculosEntrada) &&
                     Veiculo.LugarDisponiveis(veiculosEntrada, 50))
                {
                    Persistencia.GravarArquivoVeiculosEntrada(veiculo);
                    veiculosEntrada = Persistencia.LerArquivoVeiculosEntrada();

                    MessageBox.Show("Placa: " + veiculo.PlacaVeiculo.ToUpper()
                                    + "\nHora De Entrada: " + veiculo.HoraEntrada.ToString("HH:mm")
                                    + "\nData de Entrada: " + veiculo.DataEntrada,
                                    "Placa Cadastrada com sucesso");
                }
                else
                {
                    MessageBox.Show("Carro com essa placa já está na base de dados!");
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos!", "Alerta");
            }
        }

        /// <summary>
        /// Evento de click do botão de saída, faz toda a verificação, 
        /// grava no arquivo e atualiza a lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaida_Click(object sender, EventArgs e)
        {
            if (VerificarDados())
            {
                veiculosEntrada = Persistencia.LerArquivoVeiculosEntrada();
                Veiculo veiculo = new Veiculo();
                bool verificaPlaca = false;

                foreach (Veiculo item in veiculosEntrada)
                {
                    if (txtPlaca.Text == item.PlacaVeiculo)
                    {
                        veiculo = item;
                        verificaPlaca = true;
                        veiculosEntrada.Remove(item);
                        break;
                    }
                }

                if (verificaPlaca == false)
                {
                    MessageBox.Show("Placa não encontrada!");
                    return;
                }

                CalcularTempoPermanencia(veiculo);
                Persistencia.GravarArquivoVeiculosSaida(veiculo);
                Persistencia.AtualizarArquivo(veiculosEntrada, "veiculosEntrada.dat");

                veiculosSaida = Persistencia.LerArquivoVeiculosSaida();
                MessageBox.Show("Placa: " + veiculo.PlacaVeiculo.ToUpper()
                                + "\nTempo de permanencia: " + veiculo.TempoPermanencia + " minutos"
                                + "\nValor Total: R$" + veiculo.ValorCobrado + ".00",
                                "Saída feita com sucesso");
            }
            else 
            {
                MessageBox.Show("Dados inválidos!", "Alerta");
            }
        }

        /// <summary>
        /// Evento de click do botão para mudar a aba para o de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEntrada_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta("Entrada");
            this.Hide();
            consulta.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Evento de click do botão para mudar a aba para o de saída
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSaida_Click(object sender, EventArgs e)
        {
            var consulta = new Consulta("Saída");
            this.Hide();
            consulta.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Método para calcular o tempo de permanência do veículo e o valor total cobrado
        /// </summary>
        /// <param name="veiculo">Envia o veiculo para atualiza seu tempo de permanência
        /// e calcular valor</param>
        private void CalcularTempoPermanencia(Veiculo veiculo)
        {
            veiculo.TempoPermanencia = (double) DateTime.Parse(mtbHora.Text)
                .Subtract(veiculo.HoraEntrada).TotalMinutes;

            if (veiculo.TempoPermanencia % 60 > 0)
            {
                veiculo.ValorCobrado += 5 + (5 * Math.Truncate(veiculo.TempoPermanencia / 60));
            }
            else
            {
                veiculo.ValorCobrado = 5 * (veiculo.TempoPermanencia / 60);
            }
        }

        /// <summary>
        /// Verifica se os dados estão válidos
        /// </summary>
        /// <returns>retorna sim se tiver válido e não caso não tiver</returns>
        private bool VerificarDados()
        {
            return txtPlaca.Text.Count() == 7
                   && txtData.Text.Count() == 10 
                   && mtbHora.Text.Count() == 5 
                   && txtPlaca.Text.Count() > 0
                   && DateTime.Parse(mtbHora.Text).Hour > 7
                   && DateTime.Parse(mtbHora.Text).Hour < 20;
        }
    }
}
